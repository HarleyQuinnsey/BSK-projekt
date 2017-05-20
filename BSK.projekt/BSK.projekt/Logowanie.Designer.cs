namespace BSK.projekt
{
    partial class Logowanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.logInPassword = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logInUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj haslo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logInPassword
            // 
            this.logInPassword.Location = new System.Drawing.Point(16, 101);
            this.logInPassword.Name = "logInPassword";
            this.logInPassword.PasswordChar = '*';
            this.logInPassword.Size = new System.Drawing.Size(209, 20);
            this.logInPassword.TabIndex = 1;
            this.logInPassword.TextChanged += new System.EventHandler(this.logInPassword_TextChanged);
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(141, 153);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(84, 40);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Loguj";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wybierz użytkownika:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // logInUserName
            // 
            this.logInUserName.Location = new System.Drawing.Point(12, 37);
            this.logInUserName.Name = "logInUserName";
            this.logInUserName.Size = new System.Drawing.Size(213, 20);
            this.logInUserName.TabIndex = 4;
            this.logInUserName.TextChanged += new System.EventHandler(this.logInUserName_TextChanged);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(241, 218);
            this.Controls.Add(this.logInUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.logInPassword);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Logowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logInPassword;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logInUserName;
    }
}