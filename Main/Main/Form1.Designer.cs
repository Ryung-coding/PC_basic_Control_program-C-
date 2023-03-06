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
            this.tex_year = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tex_year
            // 
            this.tex_year.Location = new System.Drawing.Point(75, 89);
            this.tex_year.Name = "tex_year";
            this.tex_year.Size = new System.Drawing.Size(100, 25);
            this.tex_year.TabIndex = 0;
            this.tex_year.Text = "2023";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_out
            // 
            this.lab_out.AutoSize = true;
            this.lab_out.Font = new System.Drawing.Font("굴림", 20F);
            this.lab_out.Location = new System.Drawing.Point(200, 200);
            this.lab_out.Name = "lab_out";
            this.lab_out.Size = new System.Drawing.Size(110, 34);
            this.lab_out.TabIndex = 2;
            this.lab_out.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 413);
            this.Controls.Add(this.lab_out);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tex_year);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_out;
    }
}

