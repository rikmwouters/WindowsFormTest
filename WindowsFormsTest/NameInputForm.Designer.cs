namespace WindowsFormsTest
{
    partial class NameInputForm
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
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NameInputLabel = new System.Windows.Forms.Label();
            this.UpperLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.OverviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(12, 56);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(298, 20);
            this.NameInput.TabIndex = 0;
            // 
            // NameInputLabel
            // 
            this.NameInputLabel.AutoSize = true;
            this.NameInputLabel.Location = new System.Drawing.Point(12, 37);
            this.NameInputLabel.Name = "NameInputLabel";
            this.NameInputLabel.Size = new System.Drawing.Size(38, 13);
            this.NameInputLabel.TabIndex = 1;
            this.NameInputLabel.Text = "Name:";
            // 
            // UpperLabel
            // 
            this.UpperLabel.AutoSize = true;
            this.UpperLabel.Location = new System.Drawing.Point(9, 9);
            this.UpperLabel.Name = "UpperLabel";
            this.UpperLabel.Size = new System.Drawing.Size(103, 13);
            this.UpperLabel.TabIndex = 2;
            this.UpperLabel.Text = "Input form for names";
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(12, 79);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(298, 39);
            this.ResultLabel.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(164, 121);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(146, 23);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // OverviewButton
            // 
            this.OverviewButton.Location = new System.Drawing.Point(12, 121);
            this.OverviewButton.Name = "OverviewButton";
            this.OverviewButton.Size = new System.Drawing.Size(146, 23);
            this.OverviewButton.TabIndex = 5;
            this.OverviewButton.Text = "Show names";
            this.OverviewButton.UseVisualStyleBackColor = true;
            this.OverviewButton.Click += new System.EventHandler(this.OverviewButton_Click);
            // 
            // NameInputForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 151);
            this.Controls.Add(this.OverviewButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.UpperLabel);
            this.Controls.Add(this.NameInputLabel);
            this.Controls.Add(this.NameInput);
            this.MaximumSize = new System.Drawing.Size(338, 190);
            this.MinimumSize = new System.Drawing.Size(338, 190);
            this.Name = "NameInputForm";
            this.Text = "Name input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label NameInputLabel;
        private System.Windows.Forms.Label UpperLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button OverviewButton;
    }
}

