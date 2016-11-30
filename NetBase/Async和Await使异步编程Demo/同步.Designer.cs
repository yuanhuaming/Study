namespace Async和Await使异步编程Demo
{
    partial class 同步
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
            this.btnClick = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.主线程 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMainThreadID = new System.Windows.Forms.TextBox();
            this.txbAsynMethodID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(297, 12);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 32);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "点击我";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 282);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // 主线程
            // 
            this.主线程.AutoSize = true;
            this.主线程.Location = new System.Drawing.Point(91, 377);
            this.主线程.Name = "主线程";
            this.主线程.Size = new System.Drawing.Size(47, 12);
            this.主线程.TabIndex = 2;
            this.主线程.Text = "主线程:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "运行异步方法的线程:";
            // 
            // txbMainThreadID
            // 
            this.txbMainThreadID.Location = new System.Drawing.Point(144, 371);
            this.txbMainThreadID.Name = "txbMainThreadID";
            this.txbMainThreadID.Size = new System.Drawing.Size(100, 21);
            this.txbMainThreadID.TabIndex = 2;
            // 
            // txbAsynMethodID
            // 
            this.txbAsynMethodID.Location = new System.Drawing.Point(144, 398);
            this.txbAsynMethodID.Name = "txbAsynMethodID";
            this.txbAsynMethodID.Size = new System.Drawing.Size(100, 21);
            this.txbAsynMethodID.TabIndex = 1;
            // 
            // 同步
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 422);
            this.Controls.Add(this.txbAsynMethodID);
            this.Controls.Add(this.txbMainThreadID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.主线程);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnClick);
            this.Name = "同步";
            this.Text = "Form1";
 
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label 主线程;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMainThreadID;
        private System.Windows.Forms.TextBox txbAsynMethodID;
    }
}

