using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactGroup
{
    public partial class MainWindow: Form
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadGroup();
        }

        private void btn_add_contact_Click(object sender, EventArgs e)
        {
            AddContactWindow addContactWindow = new AddContactWindow();
            addContactWindow.ShowDialog();
        }

        private void LoadGroup()
        {
            comboBox_group.Items.Clear();
            comboBox_group.Items.Add("Tout");
            comboBox_group.Items.AddRange(Global.contactsGroup.ToArray());
        }
    }
}
