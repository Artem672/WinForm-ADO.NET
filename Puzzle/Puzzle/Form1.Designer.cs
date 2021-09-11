
namespace Puzzle
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
            this.picturePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePB)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePB
            // 
            this.picturePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturePB.Location = new System.Drawing.Point(13, 13);
            this.picturePB.Name = "picturePB";
            this.picturePB.Size = new System.Drawing.Size(573, 425);
            this.picturePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePB.TabIndex = 0;
            this.picturePB.TabStop = false;
            this.picturePB.DragDrop += new System.Windows.Forms.DragEventHandler(this.picturePB_DragDrop);
            this.picturePB.DragEnter += new System.Windows.Forms.DragEventHandler(this.picturePB_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picturePB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePB;
    }
}

