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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.NumToBit = new System.Windows.Forms.Button();
            this.BitToNum = new System.Windows.Forms.Button();
            this.ON = new System.Windows.Forms.Button();
            this.OFF = new System.Windows.Forms.Button();
            this.Toggle = new System.Windows.Forms.Button();
            this.htnShiftDown = new System.Windows.Forms.Button();
            this.htnShiftUp = new System.Windows.Forms.Button();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk0 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.txtNumber.Location = new System.Drawing.Point(12, 37);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 25);
            this.txtNumber.TabIndex = 0;
            // 
            // txtIndex
            // 
            this.txtIndex.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.txtIndex.Location = new System.Drawing.Point(12, 127);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 25);
            this.txtIndex.TabIndex = 0;
            // 
            // NumToBit
            // 
            this.NumToBit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumToBit.Location = new System.Drawing.Point(153, 14);
            this.NumToBit.Name = "NumToBit";
            this.NumToBit.Size = new System.Drawing.Size(75, 32);
            this.NumToBit.TabIndex = 1;
            this.NumToBit.Text = ">>";
            this.NumToBit.UseVisualStyleBackColor = true;
            this.NumToBit.Click += new System.EventHandler(this.NumToBit_Click);
            // 
            // BitToNum
            // 
            this.BitToNum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.BitToNum.Location = new System.Drawing.Point(153, 51);
            this.BitToNum.Name = "BitToNum";
            this.BitToNum.Size = new System.Drawing.Size(75, 32);
            this.BitToNum.TabIndex = 1;
            this.BitToNum.Text = "<<";
            this.BitToNum.UseVisualStyleBackColor = true;
            this.BitToNum.Click += new System.EventHandler(this.BitToNum_Click);
            // 
            // ON
            // 
            this.ON.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.ON.Location = new System.Drawing.Point(153, 89);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(75, 32);
            this.ON.TabIndex = 1;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // OFF
            // 
            this.OFF.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.OFF.Location = new System.Drawing.Point(153, 127);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(75, 32);
            this.OFF.TabIndex = 1;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // Toggle
            // 
            this.Toggle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.Toggle.Location = new System.Drawing.Point(153, 165);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(75, 32);
            this.Toggle.TabIndex = 1;
            this.Toggle.Text = "Toggle";
            this.Toggle.UseVisualStyleBackColor = true;
            this.Toggle.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // htnShiftDown
            // 
            this.htnShiftDown.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htnShiftDown.Location = new System.Drawing.Point(137, 243);
            this.htnShiftDown.Name = "htnShiftDown";
            this.htnShiftDown.Size = new System.Drawing.Size(91, 32);
            this.htnShiftDown.TabIndex = 1;
            this.htnShiftDown.Text = "ShiftDown";
            this.htnShiftDown.UseVisualStyleBackColor = true;
            this.htnShiftDown.Click += new System.EventHandler(this.htnShiftDown_Click);
            // 
            // htnShiftUp
            // 
            this.htnShiftUp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.htnShiftUp.Location = new System.Drawing.Point(40, 243);
            this.htnShiftUp.Name = "htnShiftUp";
            this.htnShiftUp.Size = new System.Drawing.Size(91, 32);
            this.htnShiftUp.TabIndex = 1;
            this.htnShiftUp.Text = "ShiftUp";
            this.htnShiftUp.UseVisualStyleBackColor = true;
            this.htnShiftUp.Click += new System.EventHandler(this.htnShiftUp_Click);
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(6, 24);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(40, 24);
            this.chk7.TabIndex = 2;
            this.chk7.Text = "7";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(6, 49);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(40, 24);
            this.chk6.TabIndex = 2;
            this.chk6.Text = "6";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(6, 74);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(40, 24);
            this.chk5.TabIndex = 2;
            this.chk5.Text = "5";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(6, 96);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(40, 24);
            this.chk4.TabIndex = 2;
            this.chk4.Text = "4";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(6, 121);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(40, 24);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "3";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(6, 146);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(40, 24);
            this.chk2.TabIndex = 2;
            this.chk2.Text = "2";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(6, 171);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(40, 24);
            this.chk1.TabIndex = 2;
            this.chk1.Text = "1";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk0
            // 
            this.chk0.AutoSize = true;
            this.chk0.Location = new System.Drawing.Point(6, 196);
            this.chk0.Name = "chk0";
            this.chk0.Size = new System.Drawing.Size(40, 24);
            this.chk0.TabIndex = 2;
            this.chk0.Text = "0";
            this.chk0.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk7);
            this.groupBox1.Controls.Add(this.chk0);
            this.groupBox1.Controls.Add(this.chk6);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Controls.Add(this.chk5);
            this.groupBox1.Controls.Add(this.chk2);
            this.groupBox1.Controls.Add(this.chk4);
            this.groupBox1.Controls.Add(this.chk3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(260, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bits";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "change Bit";
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.Reset.Location = new System.Drawing.Point(260, 10);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 36);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(354, 291);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.htnShiftUp);
            this.Controls.Add(this.htnShiftDown);
            this.Controls.Add(this.Toggle);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.BitToNum);
            this.Controls.Add(this.NumToBit);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Bit Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button NumToBit;
        private System.Windows.Forms.Button BitToNum;
        private System.Windows.Forms.Button ON;
        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.Button Toggle;
        private System.Windows.Forms.Button htnShiftDown;
        private System.Windows.Forms.Button htnShiftUp;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reset;
    }
}

