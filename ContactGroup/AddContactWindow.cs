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
        }
    }
}
