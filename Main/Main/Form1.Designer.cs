namespace Main
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            this.rad_black = new System.Windows.Forms.RadioButton();
            this.rad_red = new System.Windows.Forms.RadioButton();
            this.rad_blue = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(12, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(500, 500);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            // 
            // rad_black
            // 
            this.rad_black.AutoSize = true;
            this.rad_black.Checked = true;
            this.rad_black.Location = new System.Drawing.Point(546, 57);
            this.rad_black.Name = "rad_black";
            this.rad_black.Size = new System.Drawing.Size(62, 19);
            this.rad_black.TabIndex = 1;
            this.rad_black.TabStop = true;
            this.rad_black.Text = "black";
            this.rad_black.UseVisualStyleBackColor = true;
            // 
            // rad_red
            // 
            this.rad_red.AutoSize = true;
            this.rad_red.Location = new System.Drawing.Point(546, 94);
            this.rad_red.Name = "rad_red";
            this.rad_red.Size = new System.Drawing.Size(48, 19);
            this.rad_red.TabIndex = 2;
            this.rad_red.TabStop = true;
            this.rad_red.Text = "red";
            this.rad_red.UseVisualStyleBackColor = true;
            // 
            // rad_blue
            // 
            this.rad_blue.AutoSize = true;
            this.rad_blue.Location = new System.Drawing.Point(546, 132);
            this.rad_blue.Name = "rad_blue";
            this.rad_blue.Size = new System.Drawing.Size(55, 19);
            this.rad_blue.TabIndex = 3;
            this.rad_blue.TabStop = true;
            this.rad_blue.Text = "blue";
            this.rad_blue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 530);
            this.Controls.Add(this.rad_blue);
            this.Controls.Add(this.rad_red);
            this.Controls.Add(this.rad_black);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.RadioButton rad_black;
        private System.Windows.Forms.RadioButton rad_red;
        private System.Windows.Forms.RadioButton rad_blue;
    }
}

