
namespace FileReport
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
            this.components = new System.ComponentModel.Container();
            this.desktopFiles = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Extencion = new System.Windows.Forms.TextBox();
            this.Size = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.AddFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // desktopFiles
            // 
            this.desktopFiles.FormattingEnabled = true;
            this.desktopFiles.ItemHeight = 20;
            this.desktopFiles.Location = new System.Drawing.Point(13, 13);
            this.desktopFiles.Name = "desktopFiles";
            this.desktopFiles.Size = new System.Drawing.Size(364, 224);
            this.desktopFiles.TabIndex = 0;
            this.desktopFiles.SelectedIndexChanged += new System.EventHandler(this.desctopFiles_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(473, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 27);
            this.textBox1.TabIndex = 1;
            // 
            // Extencion
            // 
            this.Extencion.Enabled = false;
            this.Extencion.Location = new System.Drawing.Point(473, 55);
            this.Extencion.Name = "Extencion";
            this.Extencion.Size = new System.Drawing.Size(315, 27);
            this.Extencion.TabIndex = 2;
            // 
            // Size
            // 
            this.Size.Enabled = false;
            this.Size.Location = new System.Drawing.Point(473, 98);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(315, 27);
            this.Size.TabIndex = 3;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(13, 317);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(364, 27);
            this.FileName.TabIndex = 4;
            this.FileName.Enter += new System.EventHandler(this.FileName_Enter);
            // 
            // AddFile
            // 
            this.AddFile.Location = new System.Drawing.Point(436, 317);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(153, 29);
            this.AddFile.TabIndex = 5;
            this.AddFile.Text = "Create file";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(394, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(383, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Extencion:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(394, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Size:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFile);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.Extencion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.desktopFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox desktopFiles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Extencion;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

