using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace ARToolzUI
{
    public partial class ProviderForm : Form
    {
        public static Action UpdateProviderListBoxUI;
        public ProviderForm()
        {
            InitializeComponent();
        }

        private void ProviderSubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateProviderForm())
            {
                Provider newProvider = new Provider();
                newProvider.companyName = ProviderCompanyNameField.Text;

                AddNewProviderToCollection(newProvider);
                

            }
            UpdateProviderListBoxUI();
            Close();
        }

        private void AddNewProviderToCollection(Provider newProvider)
        {
            //string providerDataFile = System.AppDomain.CurrentDomain.BaseDirectory + "\localstorage\providerdata.json";
            string providerDataFile = @"C:\Users\jakob\Secret\providerdatatest.json";
            if (!File.Exists(providerDataFile)) { File.Create(providerDataFile); }
           
            string newProviderResults = JsonConvert.SerializeObject(newProvider);

            System.Threading.Thread.Sleep(1000); 
            File.WriteAllText(providerDataFile, newProviderResults);
        }

        private bool ValidateProviderForm()
        {


            return true;
        }
    }
}
