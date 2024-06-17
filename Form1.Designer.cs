namespace CSHARP_lsnh
{
    partial class Form1
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
            this.lbllaisuat = new System.Windows.Forms.Label();
            this.lblsonamgui = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.lbx = new System.Windows.Forms.ListBox();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.txtlaisuat = new System.Windows.Forms.TextBox();
            this.txtsonamgui = new System.Windows.Forms.TextBox();
            this.lblsotien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Lãi Suất Ngân Hàng ";
            // 
            // lbllaisuat
            // 
            this.lbllaisuat.AutoSize = true;
            this.lbllaisuat.Location = new System.Drawing.Point(54, 151);
            this.lbllaisuat.Name = "lbllaisuat";
            this.lbllaisuat.Size = new System.Drawing.Size(40, 13);
            this.lbllaisuat.TabIndex = 0;
            this.lbllaisuat.Text = "lãi suất";
            // 
            // lblsonamgui
            // 
            this.lblsonamgui.AutoSize = true;
            this.lblsonamgui.Location = new System.Drawing.Point(54, 195);
            this.lblsonamgui.Name = "lblsonamgui";
            this.lblsonamgui.Size = new System.Drawing.Size(58, 13);
            this.lblsonamgui.TabIndex = 0;
            this.lblsonamgui.Text = "số năm gửi";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(160, 249);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 1;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(57, 278);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(289, 160);
            this.lbx.TabIndex = 2;
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(125, 106);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(100, 20);
            this.txtsotien.TabIndex = 3;
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.Location = new System.Drawing.Point(125, 144);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(100, 20);
            this.txtlaisuat.TabIndex = 3;
            // 
            // txtsonamgui
            // 
            this.txtsonamgui.Location = new System.Drawing.Point(125, 188);
            this.txtsonamgui.Name = "txtsonamgui";
            this.txtsonamgui.Size = new System.Drawing.Size(100, 20);
            this.txtsonamgui.TabIndex = 3;
            // 
            // lblsotien
            // 
            this.lblsotien.AutoSize = true;
            this.lblsotien.Location = new System.Drawing.Point(54, 106);
            this.lblsotien.Name = "lblsotien";
            this.lblsotien.Size = new System.Drawing.Size(38, 13);
            this.lblsotien.TabIndex = 4;
            this.lblsotien.Text = "số tiền";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsotien);
            this.Controls.Add(this.txtsonamgui);
            this.Controls.Add(this.txtlaisuat);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lblsonamgui);
            this.Controls.Add(this.lbllaisuat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbllaisuat;
        private System.Windows.Forms.Label lblsonamgui;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.TextBox txtlaisuat;
        private System.Windows.Forms.TextBox txtsonamgui;
        private System.Windows.Forms.Label lblsotien;
    }
}

