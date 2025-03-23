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
            DialogResult dr = addContactWindow.ShowDialog();
            if (dr == DialogResult.OK)
            {
                UpdateContacts();
            }
        }

        private void UpdateContacts()
        {
            int selectedIndex = this.comboBox_group.SelectedIndex;
            if (selectedIndex == 0)
            {
                ShowAllContats();
            } else if (selectedIndex > 0)
            {
                Group group = (Group)this.comboBox_group.SelectedItem;
                ShowContactsOf(group);
            }
        }

        private void ShowContactsOf(Group group)
        {
            listBox_contacts.Items.Clear();
            listBox_contacts.Items.AddRange(group.Contacts.ToArray());
        }

        private void ShowAllContats()
        {
            listBox_contacts.Items.Clear();
            foreach (Group group in Global.contactsGroup)
            {
                listBox_contacts.Items.AddRange(group.Contacts.ToArray());
            }
        }

        private void LoadGroup()
        {
            comboBox_group.Items.Clear();
            comboBox_group.Items.Add("Tout");
            comboBox_group.SelectedIndex = 0;
            comboBox_group.Items.AddRange(Global.contactsGroup.ToArray());
        }

        private void comboBox_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContacts();
        }
    }
}
