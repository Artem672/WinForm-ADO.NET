
namespace AdoNetConnect
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
            this.AddressText = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(255, 44);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(334, 27);
            this.AddressText.TabIndex = 0;
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(255, 78);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(334, 27);
            this.LoginText.TabIndex = 1;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(255, 112);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(334, 27);
            this.PasswordText.TabIndex = 2;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(172, 44);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(77, 25);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address :";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(172, 78);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(77, 25);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login :";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(172, 112);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(77, 25);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password :";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(305, 145);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(239, 38);
            this.Connect.TabIndex = 6;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.AddressText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Connect;
    }
}

