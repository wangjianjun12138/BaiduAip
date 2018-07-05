namespace SuperRecognition
{
    partial class FormRecognition
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.m_textBoxImagePath = new System.Windows.Forms.TextBox();
            this.m_buttonGetImage = new System.Windows.Forms.Button();
            this.m_textBoxReuslt = new System.Windows.Forms.TextBox();
            this.m_buttonOK = new System.Windows.Forms.Button();
            this.m_buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_textBoxImagePath
            // 
            this.m_textBoxImagePath.Location = new System.Drawing.Point(12, 12);
            this.m_textBoxImagePath.Name = "m_textBoxImagePath";
            this.m_textBoxImagePath.Size = new System.Drawing.Size(270, 21);
            this.m_textBoxImagePath.TabIndex = 0;
            // 
            // m_buttonGetImage
            // 
            this.m_buttonGetImage.Location = new System.Drawing.Point(288, 12);
            this.m_buttonGetImage.Name = "m_buttonGetImage";
            this.m_buttonGetImage.Size = new System.Drawing.Size(43, 23);
            this.m_buttonGetImage.TabIndex = 1;
            this.m_buttonGetImage.Text = "...";
            this.m_buttonGetImage.UseVisualStyleBackColor = true;
            this.m_buttonGetImage.Click += new System.EventHandler(this.m_buttonGetImage_Click);
            // 
            // m_textBoxReuslt
            // 
            this.m_textBoxReuslt.Location = new System.Drawing.Point(12, 39);
            this.m_textBoxReuslt.Multiline = true;
            this.m_textBoxReuslt.Name = "m_textBoxReuslt";
            this.m_textBoxReuslt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_textBoxReuslt.Size = new System.Drawing.Size(319, 113);
            this.m_textBoxReuslt.TabIndex = 2;
            // 
            // m_buttonOK
            // 
            this.m_buttonOK.Location = new System.Drawing.Point(175, 158);
            this.m_buttonOK.Name = "m_buttonOK";
            this.m_buttonOK.Size = new System.Drawing.Size(75, 23);
            this.m_buttonOK.TabIndex = 3;
            this.m_buttonOK.Text = "OK";
            this.m_buttonOK.UseVisualStyleBackColor = true;
            this.m_buttonOK.Click += new System.EventHandler(this.m_buttonOK_Click);
            // 
            // m_buttonClose
            // 
            this.m_buttonClose.Location = new System.Drawing.Point(256, 158);
            this.m_buttonClose.Name = "m_buttonClose";
            this.m_buttonClose.Size = new System.Drawing.Size(75, 23);
            this.m_buttonClose.TabIndex = 4;
            this.m_buttonClose.Text = "Close";
            this.m_buttonClose.UseVisualStyleBackColor = true;
            this.m_buttonClose.Click += new System.EventHandler(this.m_buttonClose_Click);
            // 
            // FormRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 186);
            this.Controls.Add(this.m_buttonClose);
            this.Controls.Add(this.m_buttonOK);
            this.Controls.Add(this.m_textBoxReuslt);
            this.Controls.Add(this.m_buttonGetImage);
            this.Controls.Add(this.m_textBoxImagePath);
            this.Name = "FormRecognition";
            this.Text = "SuperRecognition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_textBoxImagePath;
        private System.Windows.Forms.Button m_buttonGetImage;
        private System.Windows.Forms.TextBox m_textBoxReuslt;
        private System.Windows.Forms.Button m_buttonOK;
        private System.Windows.Forms.Button m_buttonClose;
    }
}

