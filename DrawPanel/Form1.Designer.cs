
namespace DrawPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CleanPanel = new System.Windows.Forms.Button();
            this.ChangeColor = new System.Windows.Forms.Label();
            this.Pencil = new System.Windows.Forms.CheckedListBox();
            this.ChangeThickness = new System.Windows.Forms.NumericUpDown();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(176, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 398);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // CleanPanel
            // 
            this.CleanPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CleanPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CleanPanel.Location = new System.Drawing.Point(13, 379);
            this.CleanPanel.Name = "CleanPanel";
            this.CleanPanel.Size = new System.Drawing.Size(157, 40);
            this.CleanPanel.TabIndex = 1;
            this.CleanPanel.Text = "Clean";
            this.CleanPanel.UseVisualStyleBackColor = false;
            this.CleanPanel.Click += new System.EventHandler(this.CleanPanel_Click);
            // 
            // ChangeColor
            // 
            this.ChangeColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChangeColor.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ChangeColor.Location = new System.Drawing.Point(12, 348);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(54, 28);
            this.ChangeColor.TabIndex = 2;
            this.ChangeColor.Text = "Color :";
            this.ChangeColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pencil
            // 
            this.Pencil.CheckOnClick = true;
            this.Pencil.FormattingEnabled = true;
            this.Pencil.Items.AddRange(new object[] {
            "Pencil\t",
            "Rectangle"});
            this.Pencil.Location = new System.Drawing.Point(13, 21);
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(150, 48);
            this.Pencil.TabIndex = 3;
            this.Pencil.SelectedIndexChanged += new System.EventHandler(this.Pencil_SelectedIndexChanged);
            // 
            // ChangeThickness
            // 
            this.ChangeThickness.Location = new System.Drawing.Point(12, 75);
            this.ChangeThickness.Name = "ChangeThickness";
            this.ChangeThickness.Size = new System.Drawing.Size(150, 27);
            this.ChangeThickness.TabIndex = 4;
            this.ChangeThickness.ValueChanged += new System.EventHandler(this.ChangeThickness_ValueChanged);
            // 
            // ColorBox
            // 
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Items.AddRange(new object[] {
            "Aqua",
            "Black",
            "Gold",
            "Gray",
            "Green",
            "Orange",
            "Orchid",
            "Red",
            "White"});
            this.ColorBox.Location = new System.Drawing.Point(73, 348);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(97, 28);
            this.ColorBox.Sorted = true;
            this.ColorBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.ChangeThickness);
            this.Controls.Add(this.Pencil);
            this.Controls.Add(this.ChangeColor);
            this.Controls.Add(this.CleanPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeThickness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CleanPanel;
        private System.Windows.Forms.Label ChangeColor;
        private System.Windows.Forms.CheckedListBox Pencil;
        private System.Windows.Forms.NumericUpDown ChangeThickness;
        private System.Windows.Forms.ComboBox ColorBox;
    }
}

