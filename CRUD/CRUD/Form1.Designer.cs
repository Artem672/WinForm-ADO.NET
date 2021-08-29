
namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.readEmployeeButton = new System.Windows.Forms.Button();
            this.updateEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createEmployeeButton.Location = new System.Drawing.Point(153, 130);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(250, 80);
            this.createEmployeeButton.TabIndex = 0;
            this.createEmployeeButton.Text = "Create employee";
            this.createEmployeeButton.UseVisualStyleBackColor = true;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // readEmployeeButton
            // 
            this.readEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readEmployeeButton.Location = new System.Drawing.Point(409, 130);
            this.readEmployeeButton.Name = "readEmployeeButton";
            this.readEmployeeButton.Size = new System.Drawing.Size(250, 80);
            this.readEmployeeButton.TabIndex = 1;
            this.readEmployeeButton.Text = "Read employee";
            this.readEmployeeButton.UseVisualStyleBackColor = true;
            this.readEmployeeButton.Click += new System.EventHandler(this.readEmployeeButton_Click);
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateEmployeeButton.Location = new System.Drawing.Point(153, 216);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(250, 80);
            this.updateEmployeeButton.TabIndex = 2;
            this.updateEmployeeButton.Text = "Update employee";
            this.updateEmployeeButton.UseVisualStyleBackColor = true;
            this.updateEmployeeButton.Click += new System.EventHandler(this.updateEmployeeButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteEmployeeButton.Location = new System.Drawing.Point(409, 216);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(250, 80);
            this.deleteEmployeeButton.TabIndex = 3;
            this.deleteEmployeeButton.Text = "Delete employee";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.updateEmployeeButton);
            this.Controls.Add(this.readEmployeeButton);
            this.Controls.Add(this.createEmployeeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createEmployeeButton;
        private System.Windows.Forms.Button readEmployeeButton;
        private System.Windows.Forms.Button updateEmployeeButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
    }
}

