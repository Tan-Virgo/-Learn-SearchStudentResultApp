namespace SearchStudentResult
{
    partial class fSubjectSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSubjectSummary));
            this.label1 = new System.Windows.Forms.Label();
            this.cbTim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDau = new System.Windows.Forms.TextBox();
            this.txtTruot = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtTiLe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn môn học:";
            // 
            // cbTim
            // 
            this.cbTim.FormattingEnabled = true;
            this.cbTim.Location = new System.Drawing.Point(160, 17);
            this.cbTim.Name = "cbTim";
            this.cbTim.Size = new System.Drawing.Size(183, 24);
            this.cbTim.TabIndex = 1;
            this.cbTim.SelectedIndexChanged += new System.EventHandler(this.cbTim_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kết quả thống kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số sinh viên đậu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số sinh viên trượt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tỉ lệ đậu (%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Điểm trung bình:";
            // 
            // txtDau
            // 
            this.txtDau.Location = new System.Drawing.Point(200, 108);
            this.txtDau.Name = "txtDau";
            this.txtDau.ReadOnly = true;
            this.txtDau.Size = new System.Drawing.Size(208, 22);
            this.txtDau.TabIndex = 14;
            // 
            // txtTruot
            // 
            this.txtTruot.Location = new System.Drawing.Point(200, 155);
            this.txtTruot.Name = "txtTruot";
            this.txtTruot.ReadOnly = true;
            this.txtTruot.Size = new System.Drawing.Size(208, 22);
            this.txtTruot.TabIndex = 15;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(200, 206);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.ReadOnly = true;
            this.txtDiem.Size = new System.Drawing.Size(208, 22);
            this.txtDiem.TabIndex = 16;
            // 
            // txtTiLe
            // 
            this.txtTiLe.Location = new System.Drawing.Point(200, 259);
            this.txtTiLe.Name = "txtTiLe";
            this.txtTiLe.ReadOnly = true;
            this.txtTiLe.Size = new System.Drawing.Size(208, 22);
            this.txtTiLe.TabIndex = 17;
            // 
            // fSubjectSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 307);
            this.Controls.Add(this.txtTiLe);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtTruot);
            this.Controls.Add(this.txtDau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTim);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSubjectSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDau;
        private System.Windows.Forms.TextBox txtTruot;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtTiLe;
    }
}