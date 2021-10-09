
namespace Explorer
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
            this.leftTV = new System.Windows.Forms.TreeView();
            this.filesLV = new System.Windows.Forms.ListView();
            this.fileDIrectoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftTV
            // 
            this.leftTV.Location = new System.Drawing.Point(13, 12);
            this.leftTV.Name = "leftTV";
            this.leftTV.Size = new System.Drawing.Size(221, 426);
            this.leftTV.TabIndex = 0;
            this.leftTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.leftTV_AfterSelect);
            this.leftTV.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.leftTV_NodeMouseDoubleClick);
            // 
            // filesLV
            // 
            this.filesLV.HideSelection = false;
            this.filesLV.Location = new System.Drawing.Point(241, 37);
            this.filesLV.Name = "filesLV";
            this.filesLV.Size = new System.Drawing.Size(536, 401);
            this.filesLV.TabIndex = 1;
            this.filesLV.UseCompatibleStateImageBehavior = false;
            this.filesLV.SelectedIndexChanged += new System.EventHandler(this.filesLV_SelectedIndexChanged);
            this.filesLV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filesLV_KeyDown);
            this.filesLV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filesLV_MouseDoubleClick);
            // 
            // fileDIrectoryLabel
            // 
            this.fileDIrectoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileDIrectoryLabel.Location = new System.Drawing.Point(241, 12);
            this.fileDIrectoryLabel.Name = "fileDIrectoryLabel";
            this.fileDIrectoryLabel.Size = new System.Drawing.Size(536, 22);
            this.fileDIrectoryLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileDIrectoryLabel);
            this.Controls.Add(this.filesLV);
            this.Controls.Add(this.leftTV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView leftTV;
        private System.Windows.Forms.ListView filesLV;
        private System.Windows.Forms.Label fileDIrectoryLabel;
    }
}

