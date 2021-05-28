
namespace ARToolzUI
{
    partial class UserInputForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RunNumberLabel = new System.Windows.Forms.Label();
            this.RunNumberValue = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.pdfTextBox = new System.Windows.Forms.TextBox();
            this.ProviderListBox = new System.Windows.Forms.ListBox();
            this.ProviderButton_Remove = new System.Windows.Forms.Button();
            this.ProviderButton_Modify = new System.Windows.Forms.Button();
            this.ProviderButton_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunNumberLabel
            // 
            this.RunNumberLabel.AutoSize = true;
            this.RunNumberLabel.BackColor = System.Drawing.Color.White;
            this.RunNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RunNumberLabel.Location = new System.Drawing.Point(12, 26);
            this.RunNumberLabel.Name = "RunNumberLabel";
            this.RunNumberLabel.Size = new System.Drawing.Size(168, 38);
            this.RunNumberLabel.TabIndex = 0;
            this.RunNumberLabel.Text = "Run Number";
            // 
            // RunNumberValue
            // 
            this.RunNumberValue.BackColor = System.Drawing.SystemColors.Window;
            this.RunNumberValue.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunNumberValue.Location = new System.Drawing.Point(12, 67);
            this.RunNumberValue.Name = "RunNumberValue";
            this.RunNumberValue.Size = new System.Drawing.Size(182, 30);
            this.RunNumberValue.TabIndex = 1;
            this.RunNumberValue.Text = "\r\n272-20-00000";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.White;
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SubmitButton.Location = new System.Drawing.Point(362, 437);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(143, 46);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // pdfTextBox
            // 
            this.pdfTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pdfTextBox.Location = new System.Drawing.Point(225, 350);
            this.pdfTextBox.Name = "pdfTextBox";
            this.pdfTextBox.Size = new System.Drawing.Size(405, 43);
            this.pdfTextBox.TabIndex = 3;
            // 
            // ProviderListBox
            // 
            this.ProviderListBox.FormattingEnabled = true;
            this.ProviderListBox.ItemHeight = 37;
            this.ProviderListBox.Location = new System.Drawing.Point(480, 209);
            this.ProviderListBox.Name = "ProviderListBox";
            this.ProviderListBox.Size = new System.Drawing.Size(150, 115);
            this.ProviderListBox.TabIndex = 4;
            // 
            // ProviderButton_Remove
            // 
            this.ProviderButton_Remove.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderButton_Remove.Location = new System.Drawing.Point(636, 261);
            this.ProviderButton_Remove.Name = "ProviderButton_Remove";
            this.ProviderButton_Remove.Size = new System.Drawing.Size(80, 29);
            this.ProviderButton_Remove.TabIndex = 6;
            this.ProviderButton_Remove.Text = "Remove";
            this.ProviderButton_Remove.UseVisualStyleBackColor = true;
            // 
            // ProviderButton_Modify
            // 
            this.ProviderButton_Modify.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderButton_Modify.Location = new System.Drawing.Point(636, 296);
            this.ProviderButton_Modify.Name = "ProviderButton_Modify";
            this.ProviderButton_Modify.Size = new System.Drawing.Size(80, 29);
            this.ProviderButton_Modify.TabIndex = 7;
            this.ProviderButton_Modify.Text = "Modify";
            this.ProviderButton_Modify.UseVisualStyleBackColor = true;
            // 
            // ProviderButton_Add
            // 
            this.ProviderButton_Add.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderButton_Add.Location = new System.Drawing.Point(636, 226);
            this.ProviderButton_Add.Name = "ProviderButton_Add";
            this.ProviderButton_Add.Size = new System.Drawing.Size(80, 29);
            this.ProviderButton_Add.TabIndex = 8;
            this.ProviderButton_Add.Text = "Add";
            this.ProviderButton_Add.UseVisualStyleBackColor = true;
            this.ProviderButton_Add.Click += new System.EventHandler(this.ProviderButton_Add_Click);
            // 
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 495);
            this.Controls.Add(this.ProviderButton_Add);
            this.Controls.Add(this.ProviderButton_Modify);
            this.Controls.Add(this.ProviderButton_Remove);
            this.Controls.Add(this.ProviderListBox);
            this.Controls.Add(this.pdfTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RunNumberValue);
            this.Controls.Add(this.RunNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(829, 542);
            this.MinimumSize = new System.Drawing.Size(829, 542);
            this.Name = "UserInputForm";
            this.Text = "AR-Toolz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RunNumberLabel;
        private System.Windows.Forms.TextBox RunNumberValue;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox pdfTextBox;
        private System.Windows.Forms.ListBox ProviderListBox;
        private System.Windows.Forms.Button ProviderButton_Remove;
        private System.Windows.Forms.Button ProviderButton_Modify;
        private System.Windows.Forms.Button ProviderButton_Add;
    }
}

