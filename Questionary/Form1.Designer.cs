
namespace ClassWork
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
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddPerson = new System.Windows.Forms.Button();
            this.PersonAge = new System.Windows.Forms.Label();
            this.ReadFile = new System.Windows.Forms.Button();
            this.PersonPicture = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gamesCB = new System.Windows.Forms.CheckBox();
            this.readCB = new System.Windows.Forms.CheckBox();
            this.footballCB = new System.Windows.Forms.CheckBox();
            this.anotherCB = new System.Windows.Forms.CheckBox();
            this.anotherTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Canada",
            "Egypt",
            "Estonia",
            "Guinea",
            "Jamaica",
            "Mali",
            "Pakistan",
            "Serbia",
            "Slovenia",
            "Turkey",
            "Ukraine"});
            this.CountryComboBox.Location = new System.Drawing.Point(12, 153);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(282, 28);
            this.CountryComboBox.TabIndex = 0;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(12, 198);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(63, 24);
            this.MaleRadioButton.TabIndex = 2;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            this.MaleRadioButton.CheckedChanged += new System.EventHandler(this.MaleRadioButton_CheckedChanged);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(12, 228);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(78, 24);
            this.FemaleRadioButton.TabIndex = 3;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            this.FemaleRadioButton.CheckedChanged += new System.EventHandler(this.MaleRadioButton_CheckedChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(13, 13);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(281, 27);
            this.NameTextBox.TabIndex = 4;
            // 
            // SurNameTextBox
            // 
            this.SurNameTextBox.Location = new System.Drawing.Point(13, 47);
            this.SurNameTextBox.Name = "SurNameTextBox";
            this.SurNameTextBox.Size = new System.Drawing.Size(281, 27);
            this.SurNameTextBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 81);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 7, 4, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 27);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 3, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AddPerson
            // 
            this.AddPerson.Location = new System.Drawing.Point(511, 196);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(198, 29);
            this.AddPerson.TabIndex = 8;
            this.AddPerson.Text = "Save";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // PersonAge
            // 
            this.PersonAge.AutoSize = true;
            this.PersonAge.Location = new System.Drawing.Point(12, 122);
            this.PersonAge.Name = "PersonAge";
            this.PersonAge.Size = new System.Drawing.Size(47, 20);
            this.PersonAge.TabIndex = 9;
            this.PersonAge.Text = "Age : ";
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(511, 266);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(198, 29);
            this.ReadFile.TabIndex = 10;
            this.ReadFile.Text = "Read from file";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // PersonPicture
            // 
            this.PersonPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonPicture.Location = new System.Drawing.Point(511, 12);
            this.PersonPicture.Name = "PersonPicture";
            this.PersonPicture.Size = new System.Drawing.Size(198, 168);
            this.PersonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonPicture.TabIndex = 11;
            this.PersonPicture.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(55, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            // 
            // gamesCB
            // 
            this.gamesCB.AutoSize = true;
            this.gamesCB.Location = new System.Drawing.Point(12, 259);
            this.gamesCB.Name = "gamesCB";
            this.gamesCB.Size = new System.Drawing.Size(76, 24);
            this.gamesCB.TabIndex = 13;
            this.gamesCB.Text = "Games";
            this.gamesCB.UseVisualStyleBackColor = true;
            // 
            // readCB
            // 
            this.readCB.AutoSize = true;
            this.readCB.Location = new System.Drawing.Point(12, 290);
            this.readCB.Name = "readCB";
            this.readCB.Size = new System.Drawing.Size(65, 24);
            this.readCB.TabIndex = 14;
            this.readCB.Text = "Read";
            this.readCB.UseVisualStyleBackColor = true;
            // 
            // footballCB
            // 
            this.footballCB.AutoSize = true;
            this.footballCB.Location = new System.Drawing.Point(12, 321);
            this.footballCB.Name = "footballCB";
            this.footballCB.Size = new System.Drawing.Size(86, 24);
            this.footballCB.TabIndex = 15;
            this.footballCB.Text = "Football";
            this.footballCB.UseVisualStyleBackColor = true;
            // 
            // anotherCB
            // 
            this.anotherCB.AutoSize = true;
            this.anotherCB.Location = new System.Drawing.Point(12, 352);
            this.anotherCB.Name = "anotherCB";
            this.anotherCB.Size = new System.Drawing.Size(84, 24);
            this.anotherCB.TabIndex = 16;
            this.anotherCB.Text = "Another";
            this.anotherCB.UseVisualStyleBackColor = true;
            this.anotherCB.CheckedChanged += new System.EventHandler(this.anotherCB_CheckedChanged);
            // 
            // anotherTB
            // 
            this.anotherTB.Enabled = false;
            this.anotherTB.Location = new System.Drawing.Point(119, 352);
            this.anotherTB.Name = "anotherTB";
            this.anotherTB.Size = new System.Drawing.Size(125, 27);
            this.anotherTB.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save to database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.anotherTB);
            this.Controls.Add(this.anotherCB);
            this.Controls.Add(this.footballCB);
            this.Controls.Add(this.readCB);
            this.Controls.Add(this.gamesCB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PersonPicture);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.PersonAge);
            this.Controls.Add(this.AddPerson);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SurNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.CountryComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PersonPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurNameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Label PersonAge;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.PictureBox PersonPicture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox gamesCB;
        private System.Windows.Forms.CheckBox readCB;
        private System.Windows.Forms.CheckBox footballCB;
        private System.Windows.Forms.CheckBox anotherCB;
        private System.Windows.Forms.TextBox anotherTB;
        private System.Windows.Forms.Button button1;
    }
}

