
namespace CRUD.TaskForms
{
    partial class EditForm
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
            this.idCB = new System.Windows.Forms.ComboBox();
            this.priorityLB = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleLB = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.positionTB = new System.Windows.Forms.TextBox();
            this.salaryTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.removeTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idCB
            // 
            this.idCB.FormattingEnabled = true;
            this.idCB.Location = new System.Drawing.Point(56, 191);
            this.idCB.Name = "idCB";
            this.idCB.Size = new System.Drawing.Size(135, 24);
            this.idCB.TabIndex = 36;
            // 
            // priorityLB
            // 
            this.priorityLB.Enabled = false;
            this.priorityLB.FormattingEnabled = true;
            this.priorityLB.ItemHeight = 16;
            this.priorityLB.Location = new System.Drawing.Point(521, 207);
            this.priorityLB.Name = "priorityLB";
            this.priorityLB.Size = new System.Drawing.Size(223, 132);
            this.priorityLB.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Priority";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Title";
            // 
            // titleLB
            // 
            this.titleLB.FormattingEnabled = true;
            this.titleLB.ItemHeight = 16;
            this.titleLB.Location = new System.Drawing.Point(292, 207);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(223, 132);
            this.titleLB.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Find by Id";
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(56, 228);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(135, 48);
            this.findButton.TabIndex = 30;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // positionTB
            // 
            this.positionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionTB.Location = new System.Drawing.Point(404, 149);
            this.positionTB.Multiline = true;
            this.positionTB.Name = "positionTB";
            this.positionTB.Size = new System.Drawing.Size(223, 35);
            this.positionTB.TabIndex = 24;
            this.positionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // salaryTB
            // 
            this.salaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryTB.Location = new System.Drawing.Point(521, 91);
            this.salaryTB.Multiline = true;
            this.salaryTB.Name = "salaryTB";
            this.salaryTB.Size = new System.Drawing.Size(223, 35);
            this.salaryTB.TabIndex = 23;
            this.salaryTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ageTB
            // 
            this.ageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageTB.Location = new System.Drawing.Point(292, 91);
            this.ageTB.Multiline = true;
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(223, 35);
            this.ageTB.TabIndex = 22;
            this.ageTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surnameTB
            // 
            this.surnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTB.Location = new System.Drawing.Point(521, 33);
            this.surnameTB.Multiline = true;
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(223, 35);
            this.surnameTB.TabIndex = 21;
            this.surnameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.Location = new System.Drawing.Point(292, 33);
            this.nameTB.Multiline = true;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(223, 35);
            this.nameTB.TabIndex = 20;
            this.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(419, 382);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(191, 56);
            this.editButton.TabIndex = 37;
            this.editButton.Text = "Edit employee";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.Location = new System.Drawing.Point(430, 346);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(168, 30);
            this.removeTaskButton.TabIndex = 38;
            this.removeTaskButton.Text = "Remove task";
            this.removeTaskButton.UseVisualStyleBackColor = true;
            this.removeTaskButton.Click += new System.EventHandler(this.removeTaskButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeTaskButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.idCB);
            this.Controls.Add(this.priorityLB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.positionTB);
            this.Controls.Add(this.salaryTB);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.nameTB);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox idCB;
        private System.Windows.Forms.ListBox priorityLB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox titleLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox positionTB;
        private System.Windows.Forms.TextBox salaryTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeTaskButton;
    }
}