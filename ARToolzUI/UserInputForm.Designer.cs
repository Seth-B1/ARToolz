
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
            this.ProviderListBox = new System.Windows.Forms.ListBox();
            this.ProviderButton_Remove = new System.Windows.Forms.Button();
            this.ProviderButton_Add = new System.Windows.Forms.Button();
            this.FirstNameHeader = new System.Windows.Forms.Label();
            this.LastNameHeader = new System.Windows.Forms.Label();
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.DOBHeader = new System.Windows.Forms.Label();
            this.DOBField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SSNField = new System.Windows.Forms.TextBox();
            this.ClaimNumberField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MiddleNameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DOSField = new System.Windows.Forms.TextBox();
            this.AddressLine2Field = new System.Windows.Forms.TextBox();
            this.AddressLine1Field = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CityField = new System.Windows.Forms.TextBox();
            this.ZipcodeField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StateField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DescriptionField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BilledAmountField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RunNumberLabel
            // 
            this.RunNumberLabel.AutoSize = true;
            this.RunNumberLabel.BackColor = System.Drawing.Color.White;
            this.RunNumberLabel.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RunNumberLabel.Location = new System.Drawing.Point(12, 26);
            this.RunNumberLabel.Name = "RunNumberLabel";
            this.RunNumberLabel.Size = new System.Drawing.Size(131, 30);
            this.RunNumberLabel.TabIndex = 0;
            this.RunNumberLabel.Text = "Run Number";
            // 
            // RunNumberValue
            // 
            this.RunNumberValue.BackColor = System.Drawing.SystemColors.Window;
            this.RunNumberValue.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunNumberValue.Location = new System.Drawing.Point(12, 59);
            this.RunNumberValue.Name = "RunNumberValue";
            this.RunNumberValue.Size = new System.Drawing.Size(113, 30);
            this.RunNumberValue.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.White;
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SubmitButton.Location = new System.Drawing.Point(349, 484);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(143, 46);
            this.SubmitButton.TabIndex = 18;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ProviderListBox
            // 
            this.ProviderListBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderListBox.FormattingEnabled = true;
            this.ProviderListBox.ItemHeight = 28;
            this.ProviderListBox.Location = new System.Drawing.Point(12, 357);
            this.ProviderListBox.Name = "ProviderListBox";
            this.ProviderListBox.Size = new System.Drawing.Size(150, 88);
            this.ProviderListBox.TabIndex = 10;
            // 
            // ProviderButton_Remove
            // 
            this.ProviderButton_Remove.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderButton_Remove.Location = new System.Drawing.Point(168, 416);
            this.ProviderButton_Remove.Name = "ProviderButton_Remove";
            this.ProviderButton_Remove.Size = new System.Drawing.Size(80, 29);
            this.ProviderButton_Remove.TabIndex = 6;
            this.ProviderButton_Remove.TabStop = false;
            this.ProviderButton_Remove.Text = "Remove";
            this.ProviderButton_Remove.UseVisualStyleBackColor = true;
            this.ProviderButton_Remove.Click += new System.EventHandler(this.ProviderButton_Remove_Click);
            // 
            // ProviderButton_Add
            // 
            this.ProviderButton_Add.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderButton_Add.Location = new System.Drawing.Point(168, 381);
            this.ProviderButton_Add.Name = "ProviderButton_Add";
            this.ProviderButton_Add.Size = new System.Drawing.Size(80, 29);
            this.ProviderButton_Add.TabIndex = 8;
            this.ProviderButton_Add.TabStop = false;
            this.ProviderButton_Add.Text = "Add";
            this.ProviderButton_Add.UseVisualStyleBackColor = true;
            this.ProviderButton_Add.Click += new System.EventHandler(this.ProviderButton_Add_Click);
            // 
            // FirstNameHeader
            // 
            this.FirstNameHeader.AutoSize = true;
            this.FirstNameHeader.BackColor = System.Drawing.Color.White;
            this.FirstNameHeader.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FirstNameHeader.Location = new System.Drawing.Point(12, 102);
            this.FirstNameHeader.Name = "FirstNameHeader";
            this.FirstNameHeader.Size = new System.Drawing.Size(113, 30);
            this.FirstNameHeader.TabIndex = 9;
            this.FirstNameHeader.Text = "First Name";
            // 
            // LastNameHeader
            // 
            this.LastNameHeader.AutoSize = true;
            this.LastNameHeader.BackColor = System.Drawing.Color.White;
            this.LastNameHeader.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LastNameHeader.Location = new System.Drawing.Point(205, 102);
            this.LastNameHeader.Name = "LastNameHeader";
            this.LastNameHeader.Size = new System.Drawing.Size(112, 30);
            this.LastNameHeader.TabIndex = 10;
            this.LastNameHeader.Text = "Last Name";
            // 
            // FirstNameField
            // 
            this.FirstNameField.BackColor = System.Drawing.SystemColors.Window;
            this.FirstNameField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameField.Location = new System.Drawing.Point(12, 135);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(131, 30);
            this.FirstNameField.TabIndex = 4;
            // 
            // LastNameField
            // 
            this.LastNameField.BackColor = System.Drawing.SystemColors.Window;
            this.LastNameField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameField.Location = new System.Drawing.Point(205, 135);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(131, 30);
            this.LastNameField.TabIndex = 6;
            // 
            // DOBHeader
            // 
            this.DOBHeader.AutoSize = true;
            this.DOBHeader.BackColor = System.Drawing.Color.White;
            this.DOBHeader.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOBHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DOBHeader.Location = new System.Drawing.Point(11, 196);
            this.DOBHeader.Name = "DOBHeader";
            this.DOBHeader.Size = new System.Drawing.Size(57, 30);
            this.DOBHeader.TabIndex = 13;
            this.DOBHeader.Text = "DOB";
            // 
            // DOBField
            // 
            this.DOBField.BackColor = System.Drawing.SystemColors.Window;
            this.DOBField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOBField.Location = new System.Drawing.Point(12, 229);
            this.DOBField.Name = "DOBField";
            this.DOBField.Size = new System.Drawing.Size(86, 30);
            this.DOBField.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(195, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "SSN";
            // 
            // SSNField
            // 
            this.SSNField.BackColor = System.Drawing.SystemColors.Window;
            this.SSNField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SSNField.Location = new System.Drawing.Point(195, 229);
            this.SSNField.Name = "SSNField";
            this.SSNField.Size = new System.Drawing.Size(106, 30);
            this.SSNField.TabIndex = 8;
            // 
            // ClaimNumberField
            // 
            this.ClaimNumberField.BackColor = System.Drawing.SystemColors.Window;
            this.ClaimNumberField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClaimNumberField.Location = new System.Drawing.Point(11, 309);
            this.ClaimNumberField.Name = "ClaimNumberField";
            this.ClaimNumberField.Size = new System.Drawing.Size(289, 30);
            this.ClaimNumberField.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(11, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Claim #";
            // 
            // MiddleNameField
            // 
            this.MiddleNameField.BackColor = System.Drawing.SystemColors.Window;
            this.MiddleNameField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiddleNameField.Location = new System.Drawing.Point(149, 135);
            this.MiddleNameField.Name = "MiddleNameField";
            this.MiddleNameField.Size = new System.Drawing.Size(50, 30);
            this.MiddleNameField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(149, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "MI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(149, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "DOS";
            // 
            // DOSField
            // 
            this.DOSField.BackColor = System.Drawing.SystemColors.Window;
            this.DOSField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOSField.Location = new System.Drawing.Point(149, 59);
            this.DOSField.Name = "DOSField";
            this.DOSField.Size = new System.Drawing.Size(84, 30);
            this.DOSField.TabIndex = 2;
            // 
            // AddressLine2Field
            // 
            this.AddressLine2Field.BackColor = System.Drawing.SystemColors.Window;
            this.AddressLine2Field.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLine2Field.Location = new System.Drawing.Point(507, 135);
            this.AddressLine2Field.Name = "AddressLine2Field";
            this.AddressLine2Field.Size = new System.Drawing.Size(284, 30);
            this.AddressLine2Field.TabIndex = 12;
            // 
            // AddressLine1Field
            // 
            this.AddressLine1Field.BackColor = System.Drawing.SystemColors.Window;
            this.AddressLine1Field.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLine1Field.Location = new System.Drawing.Point(507, 59);
            this.AddressLine1Field.Name = "AddressLine1Field";
            this.AddressLine1Field.Size = new System.Drawing.Size(284, 30);
            this.AddressLine1Field.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(507, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 30);
            this.label6.TabIndex = 23;
            this.label6.Text = "Address Line 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(504, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "Address Line 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(504, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 30);
            this.label7.TabIndex = 29;
            this.label7.Text = "City";
            // 
            // CityField
            // 
            this.CityField.BackColor = System.Drawing.SystemColors.Window;
            this.CityField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityField.Location = new System.Drawing.Point(507, 218);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(91, 30);
            this.CityField.TabIndex = 13;
            // 
            // ZipcodeField
            // 
            this.ZipcodeField.BackColor = System.Drawing.SystemColors.Window;
            this.ZipcodeField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZipcodeField.Location = new System.Drawing.Point(690, 292);
            this.ZipcodeField.Name = "ZipcodeField";
            this.ZipcodeField.Size = new System.Drawing.Size(86, 30);
            this.ZipcodeField.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(690, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 30);
            this.label8.TabIndex = 32;
            this.label8.Text = "Zip Code";
            // 
            // StateField
            // 
            this.StateField.BackColor = System.Drawing.SystemColors.Window;
            this.StateField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateField.Location = new System.Drawing.Point(507, 292);
            this.StateField.Name = "StateField";
            this.StateField.Size = new System.Drawing.Size(86, 30);
            this.StateField.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(506, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 30);
            this.label9.TabIndex = 30;
            this.label9.Text = "State";
            // 
            // DescriptionField
            // 
            this.DescriptionField.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionField.Location = new System.Drawing.Point(399, 357);
            this.DescriptionField.Multiline = true;
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.Size = new System.Drawing.Size(471, 99);
            this.DescriptionField.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(399, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 30);
            this.label10.TabIndex = 35;
            this.label10.Text = "Description";
            // 
            // BilledAmountField
            // 
            this.BilledAmountField.BackColor = System.Drawing.SystemColors.Window;
            this.BilledAmountField.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BilledAmountField.Location = new System.Drawing.Point(252, 59);
            this.BilledAmountField.Name = "BilledAmountField";
            this.BilledAmountField.Size = new System.Drawing.Size(84, 30);
            this.BilledAmountField.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(252, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 30);
            this.label11.TabIndex = 37;
            this.label11.Text = "Billed Amount";
            // 
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BilledAmountField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DescriptionField);
            this.Controls.Add(this.ZipcodeField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StateField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CityField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddressLine2Field);
            this.Controls.Add(this.AddressLine1Field);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DOSField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MiddleNameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClaimNumberField);
            this.Controls.Add(this.SSNField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DOBField);
            this.Controls.Add(this.DOBHeader);
            this.Controls.Add(this.LastNameField);
            this.Controls.Add(this.FirstNameField);
            this.Controls.Add(this.LastNameHeader);
            this.Controls.Add(this.FirstNameHeader);
            this.Controls.Add(this.ProviderButton_Add);
            this.Controls.Add(this.ProviderButton_Remove);
            this.Controls.Add(this.ProviderListBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RunNumberValue);
            this.Controls.Add(this.RunNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(900, 600);
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
        private System.Windows.Forms.ListBox ProviderListBox;
        private System.Windows.Forms.Button ProviderButton_Remove;
        private System.Windows.Forms.Button ProviderButton_Add;
        private System.Windows.Forms.Label FirstNameHeader;
        private System.Windows.Forms.Label LastNameHeader;
        private System.Windows.Forms.TextBox FirstNameField;
        private System.Windows.Forms.TextBox LastNameField;
        private System.Windows.Forms.Label DOBHeader;
        private System.Windows.Forms.TextBox DOBField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SSNField;
        private System.Windows.Forms.TextBox ClaimNumberField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MiddleNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DOSField;
        private System.Windows.Forms.TextBox AddressLine2Field;
        private System.Windows.Forms.TextBox AddressLine1Field;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CityField;
        private System.Windows.Forms.TextBox ZipcodeField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StateField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescriptionField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BilledAmountField;
        private System.Windows.Forms.Label label11;
    }
}

