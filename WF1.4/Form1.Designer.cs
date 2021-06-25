
namespace WF1._4
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
            this.AddOpacity = new System.Windows.Forms.Button();
            this.MinOpacity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddOpacity
            // 
            this.AddOpacity.BackColor = System.Drawing.SystemColors.GrayText;
            this.AddOpacity.Location = new System.Drawing.Point(153, 205);
            this.AddOpacity.Name = "AddOpacity";
            this.AddOpacity.Size = new System.Drawing.Size(123, 51);
            this.AddOpacity.TabIndex = 0;
            this.AddOpacity.Text = "AddOpacity";
            this.AddOpacity.UseVisualStyleBackColor = false;
            this.AddOpacity.Click += new System.EventHandler(this.AddOpacity_Click);
            // 
            // MinOpacity
            // 
            this.MinOpacity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MinOpacity.Location = new System.Drawing.Point(484, 205);
            this.MinOpacity.Name = "MinOpacity";
            this.MinOpacity.Size = new System.Drawing.Size(107, 51);
            this.MinOpacity.TabIndex = 1;
            this.MinOpacity.Text = "MinOpacity";
            this.MinOpacity.UseVisualStyleBackColor = false;
            this.MinOpacity.Click += new System.EventHandler(this.MinOpacity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MinOpacity);
            this.Controls.Add(this.AddOpacity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddOpacity;
        private System.Windows.Forms.Button MinOpacity;
    }
}

