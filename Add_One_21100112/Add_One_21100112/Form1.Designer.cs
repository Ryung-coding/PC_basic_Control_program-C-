namespace Add_One_21100112
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
            this.number = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Times New Roman", 100.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.number.Location = new System.Drawing.Point(94, 160);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(164, 189);
            this.number.TabIndex = 0;
            this.number.Text = "0";
            this.number.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(464, 160);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(205, 97);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.button1_Click);
            this.Reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Reset_MouseDown);
            this.Reset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Reset_MouseUp);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.Add.Location = new System.Drawing.Point(462, 275);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(207, 101);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.button2_Click);
            this.Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Add_MouseDown);
            this.Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Add_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "If you want to increase the number, press the Add button.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(56, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(24, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(596, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "If you want to reset the number to zero, press the Reset button.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(706, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.number);
            this.Name = "Form1";
            this.Text = "Add One";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

