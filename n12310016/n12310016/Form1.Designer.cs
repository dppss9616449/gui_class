namespace n12310016
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.lab_CangeLabell = new System.Windows.Forms.Label();
            this.bnt_ChangeLabel = new System.Windows.Forms.Button();
            this.lab_Counter = new System.Windows.Forms.Label();
            this.bnt_Counter = new System.Windows.Forms.Button();
            this.btnBigger = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnCalculator = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.Location = new System.Drawing.Point(12, 3);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(99, 68);
            this.btn_ClickMe.TabIndex = 0;
            this.btn_ClickMe.Text = "按我一下";
            this.btn_ClickMe.UseVisualStyleBackColor = true;
            this.btn_ClickMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_CangeLabell
            // 
            this.lab_CangeLabell.AutoSize = true;
            this.lab_CangeLabell.Font = new System.Drawing.Font("新細明體", 25F);
            this.lab_CangeLabell.Location = new System.Drawing.Point(148, 86);
            this.lab_CangeLabell.Name = "lab_CangeLabell";
            this.lab_CangeLabell.Size = new System.Drawing.Size(93, 34);
            this.lab_CangeLabell.TabIndex = 2;
            this.lab_CangeLabell.Text = "label1";
            // 
            // bnt_ChangeLabel
            // 
            this.bnt_ChangeLabel.Location = new System.Drawing.Point(21, 86);
            this.bnt_ChangeLabel.Name = "bnt_ChangeLabel";
            this.bnt_ChangeLabel.Size = new System.Drawing.Size(75, 23);
            this.bnt_ChangeLabel.TabIndex = 1;
            this.bnt_ChangeLabel.Text = "按我換標籤";
            this.bnt_ChangeLabel.UseVisualStyleBackColor = true;
            this.bnt_ChangeLabel.Click += new System.EventHandler(this.bnt_ChangeLabel_Click);
            // 
            // lab_Counter
            // 
            this.lab_Counter.AutoSize = true;
            this.lab_Counter.Font = new System.Drawing.Font("新細明體", 25F);
            this.lab_Counter.Location = new System.Drawing.Point(182, 136);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(31, 34);
            this.lab_Counter.TabIndex = 4;
            this.lab_Counter.Text = "0";
            // 
            // bnt_Counter
            // 
            this.bnt_Counter.Location = new System.Drawing.Point(21, 133);
            this.bnt_Counter.Name = "bnt_Counter";
            this.bnt_Counter.Size = new System.Drawing.Size(75, 37);
            this.bnt_Counter.TabIndex = 3;
            this.bnt_Counter.Text = "按我加1";
            this.bnt_Counter.UseVisualStyleBackColor = true;
            this.bnt_Counter.Click += new System.EventHandler(this.bnt_Counter_Click);
            // 
            // btnBigger
            // 
            this.btnBigger.Location = new System.Drawing.Point(312, 23);
            this.btnBigger.Name = "btnBigger";
            this.btnBigger.Size = new System.Drawing.Size(75, 23);
            this.btnBigger.TabIndex = 5;
            this.btnBigger.Text = "按鈕放大";
            this.btnBigger.UseVisualStyleBackColor = true;
            this.btnBigger.Click += new System.EventHandler(this.btnBigger_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "按我至至串列";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "按我減1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnCalculator
            // 
            this.BtnCalculator.Location = new System.Drawing.Point(127, -2);
            this.BtnCalculator.Name = "BtnCalculator";
            this.BtnCalculator.Size = new System.Drawing.Size(124, 73);
            this.BtnCalculator.TabIndex = 10;
            this.BtnCalculator.Text = "計算機";
            this.BtnCalculator.UseVisualStyleBackColor = true;
            this.BtnCalculator.Click += new System.EventHandler(this.BtnCalculator_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "請輸入華氏後按下轉換按鈕";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "華氏";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "攝氏";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(426, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 63);
            this.button3.TabIndex = 11;
            this.button3.Text = "轉換";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(450, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 57);
            this.button4.TabIndex = 16;
            this.button4.Text = "timer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(402, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 73);
            this.button5.TabIndex = 17;
            this.button5.Text = "CheckBox";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(165, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 57);
            this.button6.TabIndex = 18;
            this.button6.Text = "Layout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(450, 210);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 68);
            this.button7.TabIndex = 19;
            this.button7.Text = "點餐系統";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnCalculator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBigger);
            this.Controls.Add(this.lab_Counter);
            this.Controls.Add(this.bnt_Counter);
            this.Controls.Add(this.lab_CangeLabell);
            this.Controls.Add(this.bnt_ChangeLabel);
            this.Controls.Add(this.btn_ClickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Label lab_CangeLabell;
        private System.Windows.Forms.Button bnt_ChangeLabel;
        private System.Windows.Forms.Label lab_Counter;
        private System.Windows.Forms.Button bnt_Counter;
        private System.Windows.Forms.Button btnBigger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnCalculator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

