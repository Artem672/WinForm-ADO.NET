
namespace PetrolStation
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.clearYes = new System.Windows.Forms.Button();
            this.clearNo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // clearYes
            // 
            this.clearYes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearYes.Location = new System.Drawing.Point(40, 114);
            this.clearYes.Name = "clearYes";
            this.clearYes.Size = new System.Drawing.Size(172, 58);
            this.clearYes.TabIndex = 0;
            this.clearYes.Text = "Yes";
            this.clearYes.UseVisualStyleBackColor = true;
            this.clearYes.Click += new System.EventHandler(this.clearYes_Click);
            // 
            // clearNo
            // 
            this.clearNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearNo.Location = new System.Drawing.Point(218, 114);
            this.clearNo.Name = "clearNo";
            this.clearNo.Size = new System.Drawing.Size(172, 58);
            this.clearNo.TabIndex = 1;
            this.clearNo.Text = "No";
            this.clearNo.UseVisualStyleBackColor = true;
            this.clearNo.Click += new System.EventHandler(this.clearNo_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(40, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 68);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Clear the form?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 203);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clearNo);
            this.Controls.Add(this.clearYes);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearYes;
        private System.Windows.Forms.Button clearNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}