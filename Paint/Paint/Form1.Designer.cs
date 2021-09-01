
namespace Paint
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
            this.paintPanel = new System.Windows.Forms.Panel();
            this.cleanPanelButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.drawListBox = new System.Windows.Forms.CheckedListBox();
            this.changeThicknessNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.changeThicknessNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // paintPanel
            // 
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintPanel.Location = new System.Drawing.Point(187, 13);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(601, 425);
            this.paintPanel.TabIndex = 0;
            this.paintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paintPanel_Paint);
            this.paintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseDown);
            this.paintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseMove);
            this.paintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseUp);
            // 
            // cleanPanelButton
            // 
            this.cleanPanelButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanPanelButton.Location = new System.Drawing.Point(12, 384);
            this.cleanPanelButton.Name = "cleanPanelButton";
            this.cleanPanelButton.Size = new System.Drawing.Size(168, 54);
            this.cleanPanelButton.TabIndex = 1;
            this.cleanPanelButton.Text = "Clean title";
            this.cleanPanelButton.UseVisualStyleBackColor = true;
            this.cleanPanelButton.Click += new System.EventHandler(this.cleanPanelButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorLabel.Location = new System.Drawing.Point(12, 156);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(168, 40);
            this.colorLabel.TabIndex = 2;
            this.colorLabel.Text = "Color:";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorComboBox
            // 
            this.colorComboBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(13, 199);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(168, 29);
            this.colorComboBox.TabIndex = 3;
            // 
            // drawListBox
            // 
            this.drawListBox.CheckOnClick = true;
            this.drawListBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawListBox.FormattingEnabled = true;
            this.drawListBox.Items.AddRange(new object[] {
            "Pencil",
            "Rectangle"});
            this.drawListBox.Location = new System.Drawing.Point(12, 13);
            this.drawListBox.Name = "drawListBox";
            this.drawListBox.Size = new System.Drawing.Size(168, 73);
            this.drawListBox.TabIndex = 4;
            this.drawListBox.SelectedIndexChanged += new System.EventHandler(this.drawListBox_SelectedIndexChanged);
            // 
            // changeThicknessNUD
            // 
            this.changeThicknessNUD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeThicknessNUD.Location = new System.Drawing.Point(13, 98);
            this.changeThicknessNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.changeThicknessNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.changeThicknessNUD.Name = "changeThicknessNUD";
            this.changeThicknessNUD.Size = new System.Drawing.Size(167, 28);
            this.changeThicknessNUD.TabIndex = 5;
            this.changeThicknessNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.changeThicknessNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeThicknessNUD);
            this.Controls.Add(this.drawListBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.cleanPanelButton);
            this.Controls.Add(this.paintPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.changeThicknessNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Button cleanPanelButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.CheckedListBox drawListBox;
        private System.Windows.Forms.NumericUpDown changeThicknessNUD;
    }
}

