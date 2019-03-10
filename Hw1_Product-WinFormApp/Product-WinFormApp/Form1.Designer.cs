namespace Product_WinFormApp
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LHS = new System.Windows.Forms.TextBox();
            this.RHS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LHS
            // 
            this.LHS.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHS.Location = new System.Drawing.Point(25, 82);
            this.LHS.Name = "LHS";
            this.LHS.Size = new System.Drawing.Size(214, 64);
            this.LHS.TabIndex = 0;
            this.LHS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LHS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RHS
            // 
            this.RHS.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RHS.Location = new System.Drawing.Point(277, 82);
            this.RHS.Name = "RHS";
            this.RHS.Size = new System.Drawing.Size(214, 64);
            this.RHS.TabIndex = 1;
            this.RHS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RHS.TextChanged += new System.EventHandler(this.RHS_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(527, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RHS);
            this.Controls.Add(this.LHS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LHS;
        private System.Windows.Forms.TextBox RHS;
        private System.Windows.Forms.Button button1;
    }
}

