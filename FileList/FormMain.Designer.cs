namespace FileList
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.radioButtonClipboard = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonFile);
            this.groupBoxMode.Controls.Add(this.radioButtonClipboard);
            this.groupBoxMode.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(83, 62);
            this.groupBoxMode.TabIndex = 0;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "&Mode";
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(6, 40);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(42, 16);
            this.radioButtonFile.TabIndex = 1;
            this.radioButtonFile.Text = "&File";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonClipboard
            // 
            this.radioButtonClipboard.AutoSize = true;
            this.radioButtonClipboard.Checked = true;
            this.radioButtonClipboard.Location = new System.Drawing.Point(6, 18);
            this.radioButtonClipboard.Name = "radioButtonClipboard";
            this.radioButtonClipboard.Size = new System.Drawing.Size(71, 16);
            this.radioButtonClipboard.TabIndex = 0;
            this.radioButtonClipboard.TabStop = true;
            this.radioButtonClipboard.Text = "&Clipboard";
            this.radioButtonClipboard.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "テキスト文書|*.txt|すべてのファイル|*.*";
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(107, 86);
            this.Controls.Add(this.groupBoxMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FileList";
            this.TopMost = true;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.RadioButton radioButtonClipboard;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

