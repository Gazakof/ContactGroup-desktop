﻿namespace ContactGroup
{
    partial class AddContactWindow
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
            this.picture_contact = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_group = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textB_city = new System.Windows.Forms.TextBox();
            this.textB_address = new System.Windows.Forms.TextBox();
            this.textB_last_name = new System.Windows.Forms.TextBox();
            this.textB_email = new System.Windows.Forms.TextBox();
            this.textB_phone = new System.Windows.Forms.TextBox();
            this.textB_first_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bn_add = new System.Windows.Forms.Button();
            this.btn_choose_img = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picture_contact)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_contact
            // 
            this.picture_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_contact.Location = new System.Drawing.Point(7, 9);
            this.picture_contact.Name = "picture_contact";
            this.picture_contact.Size = new System.Drawing.Size(330, 300);
            this.picture_contact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_contact.TabIndex = 1;
            this.picture_contact.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_group);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textB_city);
            this.panel1.Controls.Add(this.textB_address);
            this.panel1.Controls.Add(this.textB_last_name);
            this.panel1.Controls.Add(this.textB_email);
            this.panel1.Controls.Add(this.textB_phone);
            this.panel1.Controls.Add(this.textB_first_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 264);
            this.panel1.TabIndex = 2;
            // 
            // comboBox_group
            // 
            this.comboBox_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_group.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_group.FormattingEnabled = true;
            this.comboBox_group.Location = new System.Drawing.Point(101, 220);
            this.comboBox_group.Name = "comboBox_group";
            this.comboBox_group.Size = new System.Drawing.Size(224, 29);
            this.comboBox_group.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Last name :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textB_city
            // 
            this.textB_city.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_city.Location = new System.Drawing.Point(101, 181);
            this.textB_city.Name = "textB_city";
            this.textB_city.Size = new System.Drawing.Size(224, 29);
            this.textB_city.TabIndex = 21;
            // 
            // textB_address
            // 
            this.textB_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_address.Location = new System.Drawing.Point(101, 146);
            this.textB_address.Name = "textB_address";
            this.textB_address.Size = new System.Drawing.Size(224, 29);
            this.textB_address.TabIndex = 20;
            // 
            // textB_last_name
            // 
            this.textB_last_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_last_name.Location = new System.Drawing.Point(101, 46);
            this.textB_last_name.Name = "textB_last_name";
            this.textB_last_name.Size = new System.Drawing.Size(224, 29);
            this.textB_last_name.TabIndex = 19;
            // 
            // textB_email
            // 
            this.textB_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_email.Location = new System.Drawing.Point(101, 79);
            this.textB_email.Name = "textB_email";
            this.textB_email.Size = new System.Drawing.Size(224, 29);
            this.textB_email.TabIndex = 18;
            // 
            // textB_phone
            // 
            this.textB_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_phone.Location = new System.Drawing.Point(101, 112);
            this.textB_phone.Name = "textB_phone";
            this.textB_phone.Size = new System.Drawing.Size(224, 29);
            this.textB_phone.TabIndex = 17;
            // 
            // textB_first_name
            // 
            this.textB_first_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_first_name.Location = new System.Drawing.Point(101, 12);
            this.textB_first_name.Name = "textB_first_name";
            this.textB_first_name.Size = new System.Drawing.Size(224, 29);
            this.textB_first_name.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Group :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "First name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "City :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phone :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bn_add
            // 
            this.bn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_add.Location = new System.Drawing.Point(121, 584);
            this.bn_add.Name = "bn_add";
            this.bn_add.Size = new System.Drawing.Size(103, 31);
            this.bn_add.TabIndex = 3;
            this.bn_add.Text = "ADD";
            this.bn_add.UseVisualStyleBackColor = true;
            this.bn_add.Click += new System.EventHandler(this.bn_add_Click);
            // 
            // btn_choose_img
            // 
            this.btn_choose_img.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choose_img.Location = new System.Drawing.Point(7, 281);
            this.btn_choose_img.Name = "btn_choose_img";
            this.btn_choose_img.Size = new System.Drawing.Size(330, 28);
            this.btn_choose_img.TabIndex = 4;
            this.btn_choose_img.Text = "Choose image";
            this.btn_choose_img.UseVisualStyleBackColor = true;
            this.btn_choose_img.Click += new System.EventHandler(this.btn_choose_img_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "(Fichier PNG)|*.png|(Fichier JPEG)|*.jpeg";
            this.openFileDialog.Title = "Select an image..";
            // 
            // AddContactWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 621);
            this.Controls.Add(this.btn_choose_img);
            this.Controls.Add(this.bn_add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture_contact);
            this.Name = "AddContactWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un contact";
            ((System.ComponentModel.ISupportInitialize)(this.picture_contact)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_contact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textB_first_name;
        private System.Windows.Forms.TextBox textB_last_name;
        private System.Windows.Forms.TextBox textB_email;
        private System.Windows.Forms.TextBox textB_phone;
        private System.Windows.Forms.TextBox textB_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textB_city;
        private System.Windows.Forms.ComboBox comboBox_group;
        private System.Windows.Forms.Button bn_add;
        private System.Windows.Forms.Button btn_choose_img;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}