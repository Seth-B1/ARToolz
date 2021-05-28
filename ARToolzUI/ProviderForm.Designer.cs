
namespace ARToolzUI
{
    partial class ProviderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProviderCompanyNameField = new System.Windows.Forms.TextBox();
            this.ProviderSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProviderCompanyNameField
            // 
            this.ProviderCompanyNameField.Location = new System.Drawing.Point(54, 43);
            this.ProviderCompanyNameField.Name = "ProviderCompanyNameField";
            this.ProviderCompanyNameField.Size = new System.Drawing.Size(125, 27);
            this.ProviderCompanyNameField.TabIndex = 0;
            // 
            // ProviderSubmitButton
            // 
            this.ProviderSubmitButton.Location = new System.Drawing.Point(312, 150);
            this.ProviderSubmitButton.Name = "ProviderSubmitButton";
            this.ProviderSubmitButton.Size = new System.Drawing.Size(94, 29);
            this.ProviderSubmitButton.TabIndex = 1;
            this.ProviderSubmitButton.Text = "button1";
            this.ProviderSubmitButton.UseVisualStyleBackColor = true;
            this.ProviderSubmitButton.Click += new System.EventHandler(this.ProviderSubmitButton_Click);
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 218);
            this.Controls.Add(this.ProviderSubmitButton);
            this.Controls.Add(this.ProviderCompanyNameField);
            this.Name = "ProviderForm";
            this.Text = "Add New Provider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProviderCompanyNameField;
        private System.Windows.Forms.Button ProviderSubmitButton;
    }
}