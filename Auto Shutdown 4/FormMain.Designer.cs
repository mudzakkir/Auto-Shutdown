namespace Auto_Shutdown_4
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.pnlRBHourMinute = new System.Windows.Forms.Panel();
            this.rbMinute = new System.Windows.Forms.RadioButton();
            this.rbHour = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemaining = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlRBHourMinute.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(191, 34);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 0;
            // 
            // pnlRBHourMinute
            // 
            this.pnlRBHourMinute.Controls.Add(this.label1);
            this.pnlRBHourMinute.Controls.Add(this.rbHour);
            this.pnlRBHourMinute.Controls.Add(this.rbMinute);
            this.pnlRBHourMinute.Location = new System.Drawing.Point(314, 34);
            this.pnlRBHourMinute.Name = "pnlRBHourMinute";
            this.pnlRBHourMinute.Size = new System.Drawing.Size(200, 100);
            this.pnlRBHourMinute.TabIndex = 1;
            // 
            // rbMinute
            // 
            this.rbMinute.AutoSize = true;
            this.rbMinute.Checked = true;
            this.rbMinute.Location = new System.Drawing.Point(4, 32);
            this.rbMinute.Name = "rbMinute";
            this.rbMinute.Size = new System.Drawing.Size(69, 17);
            this.rbMinute.TabIndex = 0;
            this.rbMinute.TabStop = true;
            this.rbMinute.Text = "In Minute";
            this.rbMinute.UseVisualStyleBackColor = true;
            // 
            // rbHour
            // 
            this.rbHour.AutoSize = true;
            this.rbHour.Location = new System.Drawing.Point(4, 56);
            this.rbHour.Name = "rbHour";
            this.rbHour.Size = new System.Drawing.Size(60, 17);
            this.rbHour.TabIndex = 1;
            this.rbHour.TabStop = true;
            this.rbHour.Text = "In Hour";
            this.rbHour.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time in : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shutdown in : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time Elapsed : ";
            // 
            // txtRemaining
            // 
            this.txtRemaining.AutoSize = true;
            this.txtRemaining.Location = new System.Drawing.Point(200, 166);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(0, 13);
            this.txtRemaining.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(215, 211);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Schedule!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 454);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtRemaining);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlRBHourMinute);
            this.Controls.Add(this.txtTime);
            this.Name = "FormMain";
            this.Text = "Auto Shutdown By M.Toha";
            this.pnlRBHourMinute.ResumeLayout(false);
            this.pnlRBHourMinute.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Panel pnlRBHourMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbHour;
        private System.Windows.Forms.RadioButton rbMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtRemaining;
        private System.Windows.Forms.Button btnStart;
    }
}

