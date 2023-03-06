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
            this.button1 = new System.Windows.Forms.Button();
            this.text_year = new System.Windows.Forms.TextBox();
            this.text_month = new System.Windows.Forms.TextBox();
            this.text_day = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "calcul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_year
            // 
            this.text_year.Location = new System.Drawing.Point(86, 58);
            this.text_year.Name = "text_year";
            this.text_year.Size = new System.Drawing.Size(100, 25);
            this.text_year.TabIndex = 1;
            // 
            // text_month
            // 
            this.text_month.Location = new System.Drawing.Point(262, 58);
            this.text_month.Name = "text_month";
            this.text_month.Size = new System.Drawing.Size(100, 25);
            this.text_month.TabIndex = 2;
            // 
            // text_day
            // 
            this.text_day.Location = new System.Drawing.Point(438, 58);
            this.text_day.Name = "text_day";
            this.text_day.Size = new System.Drawing.Size(100, 25);
            this.text_day.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "d";
            // 
            // lab_out
            // 
            this.lab_out.AutoSize = true;
            this.lab_out.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_out.Location = new System.Drawing.Point(92, 187);
            this.lab_out.Name = "lab_out";
            this.lab_out.Size = new System.Drawing.Size(256, 80);
            this.lab_out.TabIndex = 7;
            this.lab_out.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 483);
            this.Controls.Add(this.lab_out);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_day);
            this.Controls.Add(this.text_month);
            this.Controls.Add(this.text_year);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_year;
        private System.Windows.Forms.TextBox text_month;
        private System.Windows.Forms.TextBox text_day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_out;
    }
}

