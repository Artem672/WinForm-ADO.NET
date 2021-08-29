
namespace CRUD.TaskForms
{
    partial class CreateForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.ageNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salaryNUP = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.positionTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.taskTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priorityNUP = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskLB = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNUP)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.Location = new System.Drawing.Point(110, 12);
            this.nameTB.Multiline = true;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(306, 35);
            this.nameTB.TabIndex = 0;
            this.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surnameTB
            // 
            this.surnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTB.Location = new System.Drawing.Point(110, 53);
            this.surnameTB.Multiline = true;
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(306, 35);
            this.surnameTB.TabIndex = 1;
            this.surnameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ageNUD
            // 
            this.ageNUD.Location = new System.Drawing.Point(110, 95);
            this.ageNUD.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ageNUD.Name = "ageNUD";
            this.ageNUD.Size = new System.Drawing.Size(306, 22);
            this.ageNUD.TabIndex = 2;
            this.ageNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age:";
            // 
            // salaryNUP
            // 
            this.salaryNUP.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.salaryNUP.Location = new System.Drawing.Point(110, 124);
            this.salaryNUP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.salaryNUP.Name = "salaryNUP";
            this.salaryNUP.Size = new System.Drawing.Size(306, 22);
            this.salaryNUP.TabIndex = 6;
            this.salaryNUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salary:";
            // 
            // positionTB
            // 
            this.positionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionTB.Location = new System.Drawing.Point(110, 152);
            this.positionTB.Multiline = true;
            this.positionTB.Name = "positionTB";
            this.positionTB.Size = new System.Drawing.Size(306, 35);
            this.positionTB.TabIndex = 8;
            this.positionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Position:";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(169, 393);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(186, 45);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create employee";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // taskTB
            // 
            this.taskTB.Location = new System.Drawing.Point(110, 193);
            this.taskTB.Multiline = true;
            this.taskTB.Name = "taskTB";
            this.taskTB.Size = new System.Drawing.Size(172, 35);
            this.taskTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Task:";
            // 
            // priorityNUP
            // 
            this.priorityNUP.Location = new System.Drawing.Point(361, 201);
            this.priorityNUP.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.priorityNUP.Name = "priorityNUP";
            this.priorityNUP.Size = new System.Drawing.Size(55, 22);
            this.priorityNUP.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Priority:";
            // 
            // addTaskButton
            // 
            this.addTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTaskButton.Location = new System.Drawing.Point(169, 235);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(186, 46);
            this.addTaskButton.TabIndex = 16;
            this.addTaskButton.Text = "Add task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // taskLB
            // 
            this.taskLB.FormattingEnabled = true;
            this.taskLB.ItemHeight = 16;
            this.taskLB.Location = new System.Drawing.Point(110, 287);
            this.taskLB.Name = "taskLB";
            this.taskLB.Size = new System.Drawing.Size(306, 84);
            this.taskLB.TabIndex = 17;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.taskLB);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priorityNUP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.taskTB);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.positionTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salaryNUP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageNUD);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.nameTB);
            this.Name = "CreateForm";
            this.Text = "Createform";
            ((System.ComponentModel.ISupportInitialize)(this.ageNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.NumericUpDown ageNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown salaryNUP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox positionTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox taskTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown priorityNUP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.ListBox taskLB;
    }
}