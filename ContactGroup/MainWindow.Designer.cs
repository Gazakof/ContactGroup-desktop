namespace ContactGroup
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group_contact_list = new System.Windows.Forms.GroupBox();
            this.btn_add_contact = new System.Windows.Forms.Button();
            this.listBox_contacts = new System.Windows.Forms.ListBox();
            this.comboBox_groups = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_right = new System.Windows.Forms.Panel();
            this.label_address = new System.Windows.Forms.Label();
            this.label_ville = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_groupe = new System.Windows.Forms.Label();
            this.picture_contact = new System.Windows.Forms.PictureBox();
            this.panel_left.SuspendLayout();
            this.panel1.SuspendLayout();
            this.group_contact_list.SuspendLayout();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_contact)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.panel1);
            this.panel_left.Controls.Add(this.group_contact_list);
            this.panel_left.Location = new System.Drawing.Point(5, 4);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(352, 553);
            this.panel_left.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 62);
            this.panel1.TabIndex = 1;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(76, 17);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(252, 25);
            this.txt_search.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            // 
            // group_contact_list
            // 
            this.group_contact_list.Controls.Add(this.btn_add_contact);
            this.group_contact_list.Controls.Add(this.listBox_contacts);
            this.group_contact_list.Controls.Add(this.comboBox_groups);
            this.group_contact_list.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_contact_list.Location = new System.Drawing.Point(9, 8);
            this.group_contact_list.Name = "group_contact_list";
            this.group_contact_list.Size = new System.Drawing.Size(334, 468);
            this.group_contact_list.TabIndex = 0;
            this.group_contact_list.TabStop = false;
            this.group_contact_list.Text = "My Contact";
            // 
            // btn_add_contact
            // 
            this.btn_add_contact.Location = new System.Drawing.Point(78, 431);
            this.btn_add_contact.Name = "btn_add_contact";
            this.btn_add_contact.Size = new System.Drawing.Size(169, 30);
            this.btn_add_contact.TabIndex = 2;
            this.btn_add_contact.Text = "Add";
            this.btn_add_contact.UseVisualStyleBackColor = true;
            // 
            // listBox_contacts
            // 
            this.listBox_contacts.FormattingEnabled = true;
            this.listBox_contacts.ItemHeight = 21;
            this.listBox_contacts.Location = new System.Drawing.Point(6, 64);
            this.listBox_contacts.Name = "listBox_contacts";
            this.listBox_contacts.Size = new System.Drawing.Size(322, 361);
            this.listBox_contacts.Sorted = true;
            this.listBox_contacts.TabIndex = 1;
            // 
            // comboBox_groups
            // 
            this.comboBox_groups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_groups.FormattingEnabled = true;
            this.comboBox_groups.Location = new System.Drawing.Point(6, 29);
            this.comboBox_groups.Name = "comboBox_groups";
            this.comboBox_groups.Size = new System.Drawing.Size(322, 29);
            this.comboBox_groups.TabIndex = 0;
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.label_address);
            this.panel_right.Controls.Add(this.label_ville);
            this.panel_right.Controls.Add(this.label6);
            this.panel_right.Controls.Add(this.label5);
            this.panel_right.Controls.Add(this.label_phone);
            this.panel_right.Controls.Add(this.label_email);
            this.panel_right.Controls.Add(this.label2);
            this.panel_right.Controls.Add(this.label_name);
            this.panel_right.Controls.Add(this.label3);
            this.panel_right.Controls.Add(this.label_groupe);
            this.panel_right.Controls.Add(this.picture_contact);
            this.panel_right.Location = new System.Drawing.Point(363, 4);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(357, 552);
            this.panel_right.TabIndex = 1;
            // 
            // label_address
            // 
            this.label_address.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(86, 419);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(252, 18);
            this.label_address.TabIndex = 11;
            this.label_address.Text = "Lot ...";
            this.label_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ville
            // 
            this.label_ville.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ville.Location = new System.Drawing.Point(86, 450);
            this.label_ville.Name = "label_ville";
            this.label_ville.Size = new System.Drawing.Size(252, 18);
            this.label_ville.TabIndex = 10;
            this.label_ville.Text = "Antananarivo";
            this.label_ville.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ville :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_phone
            // 
            this.label_phone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(86, 389);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(252, 18);
            this.label_phone.TabIndex = 7;
            this.label_phone.Text = "03X XX XXX XX";
            this.label_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_email
            // 
            this.label_email.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(86, 360);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(252, 18);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "example@test.com";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(10, 313);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(333, 35);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Name";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_groupe
            // 
            this.label_groupe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_groupe.Location = new System.Drawing.Point(238, 285);
            this.label_groupe.Name = "label_groupe";
            this.label_groupe.Size = new System.Drawing.Size(100, 18);
            this.label_groupe.TabIndex = 1;
            this.label_groupe.Text = "Groupe";
            this.label_groupe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picture_contact
            // 
            this.picture_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_contact.Location = new System.Drawing.Point(13, 8);
            this.picture_contact.Name = "picture_contact";
            this.picture_contact.Size = new System.Drawing.Size(330, 300);
            this.picture_contact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_contact.TabIndex = 0;
            this.picture_contact.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 561);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyContact";
            this.panel_left.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.group_contact_list.ResumeLayout(false);
            this.panel_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_contact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.GroupBox group_contact_list;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox_groups;
        private System.Windows.Forms.Button btn_add_contact;
        private System.Windows.Forms.ListBox listBox_contacts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.PictureBox picture_contact;
        private System.Windows.Forms.Label label_groupe;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_ville;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_phone;
    }
}

