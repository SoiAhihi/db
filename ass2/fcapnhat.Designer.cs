namespace ass2
{
    partial class fcapnhat
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmp = new System.Windows.Forms.TextBox();
            this.btUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(183, 29);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(193, 22);
            this.tbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ngày tạo";
            // 
            // tbCre
            // 
            this.tbCre.Enabled = false;
            this.tbCre.Location = new System.Drawing.Point(183, 57);
            this.tbCre.Name = "tbCre";
            this.tbCre.Size = new System.Drawing.Size(193, 22);
            this.tbCre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "tổng tiền";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(183, 85);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(193, 22);
            this.tbTotal.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "mã khách hàng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbCus
            // 
            this.tbCus.Enabled = false;
            this.tbCus.Location = new System.Drawing.Point(183, 113);
            this.tbCus.Name = "tbCus";
            this.tbCus.Size = new System.Drawing.Size(193, 22);
            this.tbCus.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "mã nhân viên";
            // 
            // tbEmp
            // 
            this.tbEmp.Enabled = false;
            this.tbEmp.Location = new System.Drawing.Point(183, 141);
            this.tbEmp.Name = "tbEmp";
            this.tbEmp.Size = new System.Drawing.Size(193, 22);
            this.tbEmp.TabIndex = 1;
            // 
            // btUp
            // 
            this.btUp.Location = new System.Drawing.Point(206, 202);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(118, 23);
            this.btUp.TabIndex = 2;
            this.btUp.Text = "Cập nhật";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // fcapnhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 260);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.tbEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Name = "fcapnhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fcapnhat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmp;
        private System.Windows.Forms.Button btUp;
    }
}