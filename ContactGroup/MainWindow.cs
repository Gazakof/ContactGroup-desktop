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
            Global.contactsGroup = SaveManager.Open();
            LoadGroup();
        }

        private void btn_add_contact_Click(object sender, EventArgs e)
        {
            AddContactWindow addContactWindow = new AddContactWindow();
            DialogResult dr = addContactWindow.ShowDialog();
            if (dr == DialogResult.OK)
            {
                UpdateContacts();
                SaveManager.Save(Global.contactsGroup);
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

            if (listBox_contacts.Items.Count > 0)
            {
                listBox_contacts.SelectedIndex = 0;
            } else
            {
                ClearInfo();
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

        private void listBox_contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact contact = (Contact)this.listBox_contacts.SelectedItem;
            if (contact != null)
            {
                ShowInfoOf(contact);
            }
        }

        private void ShowInfoOf(Contact contact)
        {
            ClearInfo();

            Image imageToShow;
            if (contact.Photo != null)
            {
                imageToShow = contact.Photo;
            } else
            {
                imageToShow = Properties.Resources.add_img;
            }

            picture_contact.Image = imageToShow;
            label_name.Text = contact.ToString();
            label_email.Text = contact.Email;
            label_phone.Text = contact.Phone;
            label_address.Text = contact.Address;
            label_ville.Text = contact.City;
            label_groupe.Text = GetGroupOf(contact).Name;
        }

        private void ClearInfo()
        {
            picture_contact.Image = Properties.Resources.add_img;
            label_name.Text = "";
            label_email.Text = "";
            label_phone.Text = "";
            label_address.Text = "";
            label_ville.Text = "";
            label_groupe.Text = "";
        }

        private Group GetGroupOf(Contact contact)
        {
            return Global.contactsGroup.Find(group => group.Contacts.Contains(contact));
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Contact contact = (Contact)listBox_contacts.SelectedItem;
            Group group = GetGroupOf(contact);

            if (contact != null && group != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this contact?",
                    "Contact Group", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    group.Contacts.Remove(contact);
                    UpdateContacts();
                    SaveManager.Save(Global.contactsGroup);
                }
            }
        }
    }
}
