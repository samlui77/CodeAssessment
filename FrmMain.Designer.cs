namespace CodeAssessment
{
    partial class FrmMain
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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnApple = new System.Windows.Forms.Button();
            this.btnSoup = new System.Windows.Forms.Button();
            this.btnMilk = new System.Windows.Forms.Button();
            this.btnBread = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCommand.Location = new System.Drawing.Point(348, 60);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(2075, 61);
            this.txtCommand.TabIndex = 0;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCommand.Location = new System.Drawing.Point(43, 60);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(299, 54);
            this.lblCommand.TabIndex = 1;
            this.lblCommand.Text = "Command Line:";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(2, 170);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(1675, 1030);
            this.txtResult.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1914, 170);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(246, 138);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Check Out";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnApple
            // 
            this.btnApple.Location = new System.Drawing.Point(158, 152);
            this.btnApple.Name = "btnApple";
            this.btnApple.Size = new System.Drawing.Size(188, 176);
            this.btnApple.TabIndex = 4;
            this.btnApple.Text = "Apple £1";
            this.btnApple.UseVisualStyleBackColor = true;
            this.btnApple.Click += new System.EventHandler(this.btnApple_Click);
            // 
            // btnSoup
            // 
            this.btnSoup.Location = new System.Drawing.Point(377, 350);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(188, 176);
            this.btnSoup.TabIndex = 5;
            this.btnSoup.Text = "Soup 65p";
            this.btnSoup.UseVisualStyleBackColor = true;
            this.btnSoup.Click += new System.EventHandler(this.btnSoup_Click);
            // 
            // btnMilk
            // 
            this.btnMilk.Location = new System.Drawing.Point(158, 350);
            this.btnMilk.Name = "btnMilk";
            this.btnMilk.Size = new System.Drawing.Size(188, 176);
            this.btnMilk.TabIndex = 6;
            this.btnMilk.Text = "Milk £1.30 ";
            this.btnMilk.UseVisualStyleBackColor = true;
            this.btnMilk.Click += new System.EventHandler(this.btnMilk_Click);
            // 
            // btnBread
            // 
            this.btnBread.Location = new System.Drawing.Point(377, 152);
            this.btnBread.Name = "btnBread";
            this.btnBread.Size = new System.Drawing.Size(188, 176);
            this.btnBread.TabIndex = 7;
            this.btnBread.Text = "Bread 80p";
            this.btnBread.UseVisualStyleBackColor = true;
            this.btnBread.Click += new System.EventHandler(this.btnBread_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnApple);
            this.groupBox1.Controls.Add(this.btnSoup);
            this.groupBox1.Controls.Add(this.btnMilk);
            this.groupBox1.Controls.Add(this.btnBread);
            this.groupBox1.Location = new System.Drawing.Point(1719, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 775);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "For Testing, Free for typing";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(2177, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(246, 138);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(2462, 1200);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.txtCommand);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCommand;
        private Label lblCommand;
        private TextBox txtResult;
        private Button btnRun;
        private Button btnApple;
        private Button btnSoup;
        private Button btnMilk;
        private Button btnBread;
        private GroupBox groupBox1;
        private Button btnClear;
    }
}