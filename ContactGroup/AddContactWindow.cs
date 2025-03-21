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
    }
}
