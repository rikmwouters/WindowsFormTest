namespace WindowsFormsTest
{
    partial class NameListForm
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
            this.NameList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NameList
            // 
            this.NameList.FormattingEnabled = true;
            this.NameList.Location = new System.Drawing.Point(74, 46);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(188, 472);
            this.NameList.TabIndex = 0;
            // 
            // NameListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 591);
            this.Controls.Add(this.NameList);
            this.Name = "NameListForm";
            this.Text = "NamesListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox NameList;
    }
}