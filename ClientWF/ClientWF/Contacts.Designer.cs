namespace ClientWF
{
    partial class Contacts
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
            this.listBox_contacts = new System.Windows.Forms.ListBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_message = new System.Windows.Forms.Button();
            this.button_room = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_contacts
            // 
            this.listBox_contacts.FormattingEnabled = true;
            this.listBox_contacts.Location = new System.Drawing.Point(12, 12);
            this.listBox_contacts.Name = "listBox_contacts";
            this.listBox_contacts.Size = new System.Drawing.Size(145, 186);
            this.listBox_contacts.TabIndex = 0;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(13, 205);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 1;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(94, 205);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_message
            // 
            this.button_message.Location = new System.Drawing.Point(164, 13);
            this.button_message.Name = "button_message";
            this.button_message.Size = new System.Drawing.Size(104, 23);
            this.button_message.TabIndex = 2;
            this.button_message.Text = "Send messager";
            this.button_message.UseVisualStyleBackColor = true;
            // 
            // button_room
            // 
            this.button_room.Location = new System.Drawing.Point(163, 42);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(104, 23);
            this.button_room.TabIndex = 2;
            this.button_room.Text = "Create room";
            this.button_room.UseVisualStyleBackColor = true;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(286, 240);
            this.Controls.Add(this.button_room);
            this.Controls.Add(this.button_message);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.listBox_contacts);
            this.Name = "Contacts";
            this.Text = "Contacts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_contacts;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_message;
        private System.Windows.Forms.Button button_room;
    }
}