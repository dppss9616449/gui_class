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
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.lab_CangeLabell = new System.Windows.Forms.Label();
            this.bnt_ChangeLabel = new System.Windows.Forms.Button();
            this.lab_Counter = new System.Windows.Forms.Label();
            this.bnt_Counter = new System.Windows.Forms.Button();
            this.btnBigger = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.Location = new System.Drawing.Point(116, 103);
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
            this.lab_CangeLabell.Location = new System.Drawing.Point(210, 209);
            this.lab_CangeLabell.Name = "lab_CangeLabell";
            this.lab_CangeLabell.Size = new System.Drawing.Size(93, 34);
            this.lab_CangeLabell.TabIndex = 2;
            this.lab_CangeLabell.Text = "label1";
            // 
            // bnt_ChangeLabel
            // 
            this.bnt_ChangeLabel.Location = new System.Drawing.Point(93, 209);
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
            this.lab_Counter.Location = new System.Drawing.Point(210, 281);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(31, 34);
            this.lab_Counter.TabIndex = 4;
            this.lab_Counter.Text = "0";
            // 
            // bnt_Counter
            // 
            this.bnt_Counter.Location = new System.Drawing.Point(93, 267);
            this.bnt_Counter.Name = "bnt_Counter";
            this.bnt_Counter.Size = new System.Drawing.Size(75, 37);
            this.bnt_Counter.TabIndex = 3;
            this.bnt_Counter.Text = "按我加1";
            this.bnt_Counter.UseVisualStyleBackColor = true;
            this.bnt_Counter.Click += new System.EventHandler(this.bnt_Counter_Click);
            // 
            // btnBigger
            // 
            this.btnBigger.Location = new System.Drawing.Point(429, 131);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

