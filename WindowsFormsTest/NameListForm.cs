using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class NameListForm : Form
    {
        List<FirstName> names = new List<FirstName>();

        public NameListForm()
        {
            InitializeComponent();
            DataAccess items = new DataAccess();
            names = items.GetNames();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            NameList.DataSource = names;
            NameList.DisplayMember = "NameString";
        }
    }
}
