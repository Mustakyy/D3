namespace D3
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_registerform = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.L_insURkey = new System.Windows.Forms.Label();
            this.TB_Rkey = new System.Windows.Forms.TextBox();
            this.B_accept = new System.Windows.Forms.Button();
            this.B_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.L_registerform, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.L_insURkey, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TB_Rkey, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.47458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.52542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // L_registerform
            // 
            this.L_registerform.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_registerform.AutoSize = true;
            this.L_registerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_registerform.Location = new System.Drawing.Point(68, 21);
            this.L_registerform.Name = "L_registerform";
            this.L_registerform.Size = new System.Drawing.Size(190, 31);
            this.L_registerform.TabIndex = 0;
            this.L_registerform.Text = "Register form";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.Controls.Add(this.B_accept, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.B_cancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 200);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 77);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // L_insURkey
            // 
            this.L_insURkey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.L_insURkey.AutoSize = true;
            this.L_insURkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_insURkey.Location = new System.Drawing.Point(33, 98);
            this.L_insURkey.Name = "L_insURkey";
            this.L_insURkey.Size = new System.Drawing.Size(261, 26);
            this.L_insURkey.TabIndex = 2;
            this.L_insURkey.Text = "Insert your registering key";
            // 
            // TB_Rkey
            // 
            this.TB_Rkey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Rkey.Location = new System.Drawing.Point(68, 150);
            this.TB_Rkey.Name = "TB_Rkey";
            this.TB_Rkey.Size = new System.Drawing.Size(190, 20);
            this.TB_Rkey.TabIndex = 3;
            // 
            // B_accept
            // 
            this.B_accept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_accept.Location = new System.Drawing.Point(30, 18);
            this.B_accept.Name = "B_accept";
            this.B_accept.Size = new System.Drawing.Size(100, 40);
            this.B_accept.TabIndex = 0;
            this.B_accept.Text = "Accept";
            this.B_accept.UseVisualStyleBackColor = true;
            this.B_accept.Click += new System.EventHandler(this.B_accept_Click);
            // 
            // B_cancel
            // 
            this.B_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_cancel.Location = new System.Drawing.Point(191, 18);
            this.B_cancel.Name = "B_cancel";
            this.B_cancel.Size = new System.Drawing.Size(100, 40);
            this.B_cancel.TabIndex = 1;
            this.B_cancel.Text = "Cancel";
            this.B_cancel.UseVisualStyleBackColor = true;
            this.B_cancel.Click += new System.EventHandler(this.B_cancel_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 280);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L_registerform;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button B_accept;
        private System.Windows.Forms.Label L_insURkey;
        private System.Windows.Forms.TextBox TB_Rkey;
        private System.Windows.Forms.Button B_cancel;
    }
}