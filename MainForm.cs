using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AdminRighter
{
    public partial class MainForm : Form
    {
        private const string RegistryAccessGrantValue = "^ RUNASADMIN";
        private const string RegistryKey = @"Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers";

        public MainForm()
        {
            InitializeComponent();
            LoadApps();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void SelectFile()
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = dlgOpen.FileName;
            }
        }

        private void GrantAccess()
        {
            if (String.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show(@"Please select an executable file to proceed.", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var key = Registry.CurrentUser.CreateSubKey(RegistryKey);
            if (key != null)
            {
                var existingValue = key.GetValue(txtFileName.Text);
                if (existingValue == null)
                {
                    key.SetValue(txtFileName.Text, RegistryAccessGrantValue, RegistryValueKind.String);
                    key.Close();
                }
                LoadApps();
            }
        }

        private void btnGrantAccess_Click(object sender, EventArgs e)
        {
            GrantAccess();
        }

        private void LoadApps()
        {
            lstApps.Items.Clear();
            var key = Registry.CurrentUser.CreateSubKey(RegistryKey);
            if (key != null)
            {
                var values = key.GetValueNames();
                foreach (var val in values)
                {
                    lstApps.Items.Add(val);
                }
                key.Close();
            }

            if (lstApps.Items.Count > 0)
                lstApps.SelectedIndex = 0;

            btnRemoveApp.Enabled = lstApps.Items.Count != 0;
        }

        private void btnRemoveApp_Click(object sender, EventArgs e)
        {
            RemoveApp();
        }

        private void RemoveApp()
        {
            if (lstApps.SelectedIndex >= 0)
            {
                var key = Registry.CurrentUser.CreateSubKey(RegistryKey);
                if (key != null)
                {
                    key.DeleteValue(lstApps.SelectedItem.ToString());
                    key.Close();
                    LoadApps();
                }
            }
        }
    }
}
