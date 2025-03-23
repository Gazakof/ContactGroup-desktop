using System;
using System.Windows.Forms;
using System.Drawing;

namespace ContactGroup
{
    public partial class AddContactWindow: Form
    {
        public AddContactWindow()
        {
            InitializeComponent();
            LoadGroup();
        }

        private void LoadGroup()
        {
            comboBox_group.Items.Clear();
            comboBox_group.Items.AddRange(Global.contactsGroup.ToArray());

            if (comboBox_group.Items != null)
            {
                comboBox_group.SelectedIndex = 0;
            }
        }

        private void bn_add_Click(object sender, EventArgs e)
        {
            string firstName = textB_last_name.Text;
            string lastName = textB_first_name.Text;
            string email = textB_email.Text;
            string phone = textB_phone.Text;
            string address = textB_address.Text;
            string city = textB_city.Text;
            Group group = (Group)comboBox_group.SelectedItem;
            Image picture = picture_contact.Image;

            if (checkInputs(firstName, lastName, email, phone, address, city, group))
            {
                Contact contact = new Contact(firstName, lastName, email, phone, address, city, picture);

                group.Contacts.Add(contact);

                DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("Please, fill all the fields correctly!", "Contact Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool checkInputs(string firstName, string lastName, string email, string phone, string address, string city, Group group)
        {
            return !string.IsNullOrEmpty(firstName)
                && !string.IsNullOrEmpty(lastName)
                && !string.IsNullOrEmpty(email)
                && !string.IsNullOrEmpty(phone)
                && !string.IsNullOrEmpty(address)
                && !string.IsNullOrEmpty(city)
                && group != null;
        }

        private void btn_choose_img_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                picture_contact.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
