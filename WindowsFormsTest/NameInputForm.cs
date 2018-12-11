using System;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class NameInputForm : Form
    {
        public NameInputForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = this.NameInput.Text;
            if(name != null){
                DataAccess access = new DataAccess();
                access.AddName(name);
            }
            this.ResultLabel.Text = this.NameInput.Text + " is toegevoegd aan de database.";
            this.NameInput.Text = string.Empty;
            FocusInputText();
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            new NameListForm().Show();
        }

        private void FocusInputText()
        {
            this.NameInput.Focus();
        }
    }
}
