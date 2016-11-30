namespace Async和Await使异步编程Demo
{
    partial class 异步2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbAsynMethodID = new System.Windows.Forms.TextBox();
            this.txbMainThreadID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.主线程 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbAsynMethodID
            // 
            this.txbAsynMethodID.Location = new System.Drawing.Point(156, 432);
            this.txbAsynMethodID.Name = "txbAsynMethodID";
            this.txbAsynMethodID.Size = new System.Drawing.Size(100, 21);
            this.txbAsynMethodID.TabIndex = 17;
            // 
            // txbMainThreadID
            // 
            this.txbMainThreadID.Location = new System.Drawing.Point(156, 405);
            this.txbMainThreadID.Name = "txbMainThreadID";
            this.txbMainThreadID.Size = new System.Drawing.Size(100, 21);
            this.txbMainThreadID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "运行异步方法的线程:";
            // 
            // 主线程
            // 
            this.主线程.AutoSize = true;
            this.主线程.Location = new System.Drawing.Point(103, 411);
            this.主线程.Name = "主线程";
            this.主线程.Size = new System.Drawing.Size(47, 12);
            this.主线程.TabIndex = 14;
            this.主线程.Text = "主线程:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 282);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(309, 46);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 32);
            this.btnClick.TabIndex = 12;
            this.btnClick.Text = "点击我";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 18;
            // 
            // 异步2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 498);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbAsynMethodID);
            this.Controls.Add(this.txbMainThreadID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.主线程);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnClick);
            this.Name = "异步2";
            this.Text = "异步2";
            this.Load += new System.EventHandler(this.异步2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAsynMethodID;
        private System.Windows.Forms.TextBox txbMainThreadID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 主线程;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox textBox1;
    }
}