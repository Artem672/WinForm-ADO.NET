
namespace TaskManager
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopByNameButton = new System.Windows.Forms.Button();
            this.startProcessButton = new System.Windows.Forms.Button();
            this.processNameTB = new System.Windows.Forms.TextBox();
            this.stopByIdButton = new System.Windows.Forms.Button();
            this.processesDGW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.processesDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(680, 405);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(119, 33);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopByNameButton
            // 
            this.stopByNameButton.Location = new System.Drawing.Point(680, 327);
            this.stopByNameButton.Name = "stopByNameButton";
            this.stopByNameButton.Size = new System.Drawing.Size(119, 33);
            this.stopByNameButton.TabIndex = 1;
            this.stopByNameButton.Text = "Stop by name";
            this.stopByNameButton.UseVisualStyleBackColor = true;
            this.stopByNameButton.Click += new System.EventHandler(this.stopByNameButton_Click);
            // 
            // startProcessButton
            // 
            this.startProcessButton.Location = new System.Drawing.Point(680, 12);
            this.startProcessButton.Name = "startProcessButton";
            this.startProcessButton.Size = new System.Drawing.Size(119, 33);
            this.startProcessButton.TabIndex = 2;
            this.startProcessButton.Text = "Start process";
            this.startProcessButton.UseVisualStyleBackColor = true;
            this.startProcessButton.Click += new System.EventHandler(this.startProcessButton_Click);
            // 
            // processNameTB
            // 
            this.processNameTB.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processNameTB.Location = new System.Drawing.Point(12, 12);
            this.processNameTB.Multiline = true;
            this.processNameTB.Name = "processNameTB";
            this.processNameTB.Size = new System.Drawing.Size(662, 33);
            this.processNameTB.TabIndex = 3;
            this.processNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stopByIdButton
            // 
            this.stopByIdButton.Location = new System.Drawing.Point(680, 366);
            this.stopByIdButton.Name = "stopByIdButton";
            this.stopByIdButton.Size = new System.Drawing.Size(119, 33);
            this.stopByIdButton.TabIndex = 4;
            this.stopByIdButton.Text = "Stop by id";
            this.stopByIdButton.UseVisualStyleBackColor = true;
            this.stopByIdButton.Click += new System.EventHandler(this.stopByIdButton_Click);
            // 
            // processesDGW
            // 
            this.processesDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processesDGW.Location = new System.Drawing.Point(13, 52);
            this.processesDGW.Name = "processesDGW";
            this.processesDGW.RowHeadersWidth = 51;
            this.processesDGW.RowTemplate.Height = 24;
            this.processesDGW.Size = new System.Drawing.Size(661, 386);
            this.processesDGW.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.processesDGW);
            this.Controls.Add(this.stopByIdButton);
            this.Controls.Add(this.processNameTB);
            this.Controls.Add(this.startProcessButton);
            this.Controls.Add(this.stopByNameButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.processesDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopByNameButton;
        private System.Windows.Forms.Button startProcessButton;
        private System.Windows.Forms.TextBox processNameTB;
        private System.Windows.Forms.Button stopByIdButton;
        private System.Windows.Forms.DataGridView processesDGW;
    }
}

