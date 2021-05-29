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
            //UpdateProviderListBoxUI();
            Close();
        }

        private void AddNewProviderToCollection(Provider newProvider)
        {
            //string providerDataFile = System.AppDomain.CurrentDomain.BaseDirectory + "\localstorage\providerdata.json";
            string providerDataFile = @"C:\Users\jakob\Secret\providerdatatest.json";
            StringBuilder sb = new StringBuilder(providerDataFile);
            StringWriter sw = new StringWriter(sb);
            JsonWriter jWriter = new JsonTextWriter(sw);
            jWriter.Formatting = Formatting.Indented;

            jWriter.WriteStartObject();
            jWriter.WritePropertyName("companyName");
            jWriter.WriteValue(newProvider.companyName);
            jWriter.WriteEndObject();

            //string newProviderResults = JsonConvert.SerializeObject(newProvider);            
        }

        private bool ValidateProviderForm()
        {


            return true;
        }
    }
}
