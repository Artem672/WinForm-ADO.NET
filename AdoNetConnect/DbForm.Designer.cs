
namespace AdoNetConnect
{
    partial class DbForm
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
            this.dbbox = new System.Windows.Forms.ComboBox();
            this.ShowTables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbbox
            // 
            this.dbbox.FormattingEnabled = true;
            this.dbbox.Location = new System.Drawing.Point(12, 12);
            this.dbbox.Name = "dbbox";
            this.dbbox.Size = new System.Drawing.Size(242, 28);
            this.dbbox.TabIndex = 0;
            this.dbbox.Click += new System.EventHandler(this.dbbox_Click);
            // 
            // ShowTables
            // 
            this.ShowTables.Location = new System.Drawing.Point(274, 12);
            this.ShowTables.Name = "ShowTables";
            this.ShowTables.Size = new System.Drawing.Size(153, 29);
            this.ShowTables.TabIndex = 1;
            this.ShowTables.Text = "Show tables";
            this.ShowTables.UseVisualStyleBackColor = true;
            this.ShowTables.Click += new System.EventHandler(this.ShowTables_Click);
            // 
            // DbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 310);
            this.Controls.Add(this.ShowTables);
            this.Controls.Add(this.dbbox);
            this.Name = "DbForm";
            this.Text = "DbForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dbbox;
        private System.Windows.Forms.Button ShowTables;
    }
}