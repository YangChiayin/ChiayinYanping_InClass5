namespace ChiayinYanping_InClass5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btnAddNewUser = new Button();
            btnGetNewId = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblMessage = new Label();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            btnSavePhrase = new Button();
            btnShowAllPhrases = new Button();
            txtPhrase = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btnAddNewUser);
            groupBox1.Controls.Add(btnGetNewId);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 548);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New user:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(195, 302);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(440, 39);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.Location = new Point(22, 375);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(196, 81);
            btnAddNewUser.TabIndex = 2;
            btnAddNewUser.Text = "Add new user";
            btnAddNewUser.UseVisualStyleBackColor = true;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // btnGetNewId
            // 
            btnGetNewId.Location = new Point(439, 43);
            btnGetNewId.Name = "btnGetNewId";
            btnGetNewId.Size = new Size(196, 81);
            btnGetNewId.TabIndex = 2;
            btnGetNewId.Text = "Get new ID";
            btnGetNewId.UseVisualStyleBackColor = true;
            btnGetNewId.Click += btnGetNewId_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(195, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(440, 39);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(195, 147);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(440, 39);
            txtUsername.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(195, 67);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 39);
            txtId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 307);
            label4.Name = "label4";
            label4.Size = new Size(155, 32);
            label4.TabIndex = 0;
            label4.Text = "Date created:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 233);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 147);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 67);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(23, 590);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 32);
            lblMessage.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(btnSavePhrase);
            groupBox2.Controls.Add(btnShowAllPhrases);
            groupBox2.Controls.Add(txtPhrase);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(694, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(665, 548);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other stuff:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(30, 247);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(613, 256);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // btnSavePhrase
            // 
            btnSavePhrase.Location = new Point(30, 147);
            btnSavePhrase.Name = "btnSavePhrase";
            btnSavePhrase.Size = new Size(180, 81);
            btnSavePhrase.TabIndex = 2;
            btnSavePhrase.Text = "Save phrase";
            btnSavePhrase.UseVisualStyleBackColor = true;
            btnSavePhrase.Click += btnSavePhrase_Click;
            // 
            // btnShowAllPhrases
            // 
            btnShowAllPhrases.Location = new Point(408, 147);
            btnShowAllPhrases.Name = "btnShowAllPhrases";
            btnShowAllPhrases.Size = new Size(235, 81);
            btnShowAllPhrases.TabIndex = 2;
            btnShowAllPhrases.Text = "Show all phrases";
            btnShowAllPhrases.UseVisualStyleBackColor = true;
            btnShowAllPhrases.Click += btnShowAllPhrases_Click;
            // 
            // txtPhrase
            // 
            txtPhrase.Location = new Point(203, 67);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(440, 39);
            txtPhrase.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 67);
            label7.Name = "label7";
            label7.Size = new Size(89, 32);
            label7.TabIndex = 0;
            label7.Text = "Phrase:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 754);
            Controls.Add(lblMessage);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Users";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtId;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button btnGetNewId;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAddNewUser;
        private Label lblMessage;
        private GroupBox groupBox2;
        private Button btnShowAllPhrases;
        private TextBox txtPhrase;
        private Label label7;
        private RichTextBox richTextBox1;
        private Button btnSavePhrase;
    }
}
