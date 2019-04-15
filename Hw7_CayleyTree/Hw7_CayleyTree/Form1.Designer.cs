namespace Hw7_CayleyTree
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
            this.draw = new System.Windows.Forms.Button();
            this.vScrollBar_per2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar_per1 = new System.Windows.Forms.VScrollBar();
            this.color = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.draw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.draw.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.draw.Location = new System.Drawing.Point(1171, 684);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(137, 75);
            this.draw.TabIndex = 0;
            this.draw.Text = "draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // vScrollBar_per2
            // 
            this.vScrollBar_per2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar_per2.Location = new System.Drawing.Point(1288, 312);
            this.vScrollBar_per2.Maximum = 70;
            this.vScrollBar_per2.Name = "vScrollBar_per2";
            this.vScrollBar_per2.Size = new System.Drawing.Size(20, 322);
            this.vScrollBar_per2.TabIndex = 1;
            this.vScrollBar_per2.Value = 40;
            this.vScrollBar_per2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_per2_Scroll);
            // 
            // vScrollBar_per1
            // 
            this.vScrollBar_per1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar_per1.Location = new System.Drawing.Point(1171, 312);
            this.vScrollBar_per1.Maximum = 70;
            this.vScrollBar_per1.Name = "vScrollBar_per1";
            this.vScrollBar_per1.Size = new System.Drawing.Size(20, 322);
            this.vScrollBar_per1.TabIndex = 2;
            this.vScrollBar_per1.Value = 50;
            this.vScrollBar_per1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_per1_Scroll);
            // 
            // color
            // 
            this.color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.color.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.color.FormattingEnabled = true;
            this.color.ItemHeight = 36;
            this.color.Items.AddRange(new object[] {
            "red",
            "yellow",
            "blue",
            "black",
            "pink"});
            this.color.Location = new System.Drawing.Point(1171, 62);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(137, 184);
            this.color.TabIndex = 3;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 800);
            this.Controls.Add(this.color);
            this.Controls.Add(this.vScrollBar_per1);
            this.Controls.Add(this.vScrollBar_per2);
            this.Controls.Add(this.draw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.VScrollBar vScrollBar_per2;
        private System.Windows.Forms.VScrollBar vScrollBar_per1;
        private System.Windows.Forms.ListBox color;
    }
}

