namespace LoginScreen
{
    partial class Form1
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
            button_login = new Button();
            label1 = new Label();
            txt_username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_password = new TextBox();
            SuspendLayout();
            // 
            // button_login
            // 
            button_login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_login.Location = new Point(172, 231);
            button_login.Name = "button_login";
            button_login.Size = new Size(203, 23);
            button_login.TabIndex = 0;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 101);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_username.Location = new Point(141, 101);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(305, 23);
            txt_username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(216, 9);
            label2.Name = "label2";
            label2.Size = new Size(92, 24);
            label2.TabIndex = 3;
            label2.Text = "Welcome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 156);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_password.Location = new Point(141, 156);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(305, 23);
            txt_password.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 388);
            Controls.Add(txt_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_username);
            Controls.Add(label1);
            Controls.Add(button_login);
            Name = "Form1";
            Text = "LoginScreen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_login;
        private Label label1;
        private TextBox txt_username;
        private Label label2;
        private Label label3;
        private TextBox txt_password;
    }
}
