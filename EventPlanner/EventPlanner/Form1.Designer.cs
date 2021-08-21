
namespace EventPlanner
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
            this.eventNameTB = new System.Windows.Forms.TextBox();
            this.eventPlaceTB = new System.Windows.Forms.TextBox();
            this.eventDTPicker = new System.Windows.Forms.DateTimePicker();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventPlaceLabel = new System.Windows.Forms.Label();
            this.priorityCB = new System.Windows.Forms.ComboBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.eventDateLabel = new System.Windows.Forms.Label();
            this.addEventButton = new System.Windows.Forms.Button();
            this.clearEventButton = new System.Windows.Forms.Button();
            this.saveJsonButton = new System.Windows.Forms.Button();
            this.saveXMLButton = new System.Windows.Forms.Button();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.eventsLabel = new System.Windows.Forms.Label();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventNameTB
            // 
            this.eventNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventNameTB.Location = new System.Drawing.Point(149, 30);
            this.eventNameTB.Multiline = true;
            this.eventNameTB.Name = "eventNameTB";
            this.eventNameTB.Size = new System.Drawing.Size(317, 47);
            this.eventNameTB.TabIndex = 0;
            // 
            // eventPlaceTB
            // 
            this.eventPlaceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventPlaceTB.Location = new System.Drawing.Point(149, 83);
            this.eventPlaceTB.Multiline = true;
            this.eventPlaceTB.Name = "eventPlaceTB";
            this.eventPlaceTB.Size = new System.Drawing.Size(317, 47);
            this.eventPlaceTB.TabIndex = 1;
            // 
            // eventDTPicker
            // 
            this.eventDTPicker.Location = new System.Drawing.Point(149, 136);
            this.eventDTPicker.Name = "eventDTPicker";
            this.eventDTPicker.Size = new System.Drawing.Size(317, 22);
            this.eventDTPicker.TabIndex = 2;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(48, 43);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(87, 17);
            this.eventNameLabel.TabIndex = 3;
            this.eventNameLabel.Text = "Event name:";
            // 
            // eventPlaceLabel
            // 
            this.eventPlaceLabel.AutoSize = true;
            this.eventPlaceLabel.Location = new System.Drawing.Point(48, 95);
            this.eventPlaceLabel.Name = "eventPlaceLabel";
            this.eventPlaceLabel.Size = new System.Drawing.Size(86, 17);
            this.eventPlaceLabel.TabIndex = 4;
            this.eventPlaceLabel.Text = "Event place:";
            // 
            // priorityCB
            // 
            this.priorityCB.FormattingEnabled = true;
            this.priorityCB.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.priorityCB.Location = new System.Drawing.Point(149, 164);
            this.priorityCB.Name = "priorityCB";
            this.priorityCB.Size = new System.Drawing.Size(317, 24);
            this.priorityCB.TabIndex = 5;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(48, 167);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(95, 17);
            this.priorityLabel.TabIndex = 6;
            this.priorityLabel.Text = "Event priority:";
            // 
            // eventDateLabel
            // 
            this.eventDateLabel.AutoSize = true;
            this.eventDateLabel.Location = new System.Drawing.Point(48, 136);
            this.eventDateLabel.Name = "eventDateLabel";
            this.eventDateLabel.Size = new System.Drawing.Size(80, 17);
            this.eventDateLabel.TabIndex = 7;
            this.eventDateLabel.Text = "Event date:";
            // 
            // addEventButton
            // 
            this.addEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEventButton.Location = new System.Drawing.Point(149, 195);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(155, 47);
            this.addEventButton.TabIndex = 8;
            this.addEventButton.Text = "Add";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // clearEventButton
            // 
            this.clearEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearEventButton.Location = new System.Drawing.Point(311, 195);
            this.clearEventButton.Name = "clearEventButton";
            this.clearEventButton.Size = new System.Drawing.Size(155, 47);
            this.clearEventButton.TabIndex = 9;
            this.clearEventButton.Text = "Clear events";
            this.clearEventButton.UseVisualStyleBackColor = true;
            this.clearEventButton.Click += new System.EventHandler(this.clearEventButton_Click);
            // 
            // saveJsonButton
            // 
            this.saveJsonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveJsonButton.Location = new System.Drawing.Point(149, 249);
            this.saveJsonButton.Name = "saveJsonButton";
            this.saveJsonButton.Size = new System.Drawing.Size(155, 47);
            this.saveJsonButton.TabIndex = 10;
            this.saveJsonButton.Text = "Save as JSON";
            this.saveJsonButton.UseVisualStyleBackColor = true;
            this.saveJsonButton.Click += new System.EventHandler(this.saveJsonButton_Click);
            // 
            // saveXMLButton
            // 
            this.saveXMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveXMLButton.Location = new System.Drawing.Point(311, 249);
            this.saveXMLButton.Name = "saveXMLButton";
            this.saveXMLButton.Size = new System.Drawing.Size(155, 47);
            this.saveXMLButton.TabIndex = 11;
            this.saveXMLButton.Text = "Save as XML";
            this.saveXMLButton.UseVisualStyleBackColor = true;
            this.saveXMLButton.Click += new System.EventHandler(this.saveXMLButton_Click);
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 16;
            this.eventsListBox.Location = new System.Drawing.Point(149, 393);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(317, 148);
            this.eventsListBox.TabIndex = 12;
            this.eventsListBox.SelectedIndexChanged += new System.EventHandler(this.eventsListBox_SelectedIndexChanged);
            // 
            // eventsLabel
            // 
            this.eventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventsLabel.Location = new System.Drawing.Point(272, 367);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(75, 23);
            this.eventsLabel.TabIndex = 13;
            this.eventsLabel.Text = "Events:";
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFieldsButton.Location = new System.Drawing.Point(149, 302);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(155, 62);
            this.clearFieldsButton.TabIndex = 14;
            this.clearFieldsButton.Text = "Clear fields";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // readButton
            // 
            this.readButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readButton.Location = new System.Drawing.Point(311, 303);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(155, 61);
            this.readButton.TabIndex = 15;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 553);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.eventsLabel);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.saveXMLButton);
            this.Controls.Add(this.saveJsonButton);
            this.Controls.Add(this.clearEventButton);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.eventDateLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.priorityCB);
            this.Controls.Add(this.eventPlaceLabel);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.eventDTPicker);
            this.Controls.Add(this.eventPlaceTB);
            this.Controls.Add(this.eventNameTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventNameTB;
        private System.Windows.Forms.TextBox eventPlaceTB;
        private System.Windows.Forms.DateTimePicker eventDTPicker;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label eventPlaceLabel;
        private System.Windows.Forms.ComboBox priorityCB;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label eventDateLabel;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button clearEventButton;
        private System.Windows.Forms.Button saveJsonButton;
        private System.Windows.Forms.Button saveXMLButton;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.Button readButton;
    }
}

