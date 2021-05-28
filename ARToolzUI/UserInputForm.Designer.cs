
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
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 495);
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
    }
}

