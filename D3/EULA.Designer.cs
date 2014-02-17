namespace D3
{
    partial class EULA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EULA));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.B_accept = new System.Windows.Forms.Button();
            this.B_decline = new System.Windows.Forms.Button();
            this.L_EULA = new System.Windows.Forms.Label();
            this.rTB_EULA = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.L_EULA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rTB_EULA, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.96025F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.03976F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.B_accept, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.B_decline, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 330);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(456, 170);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // B_accept
            // 
            this.B_accept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_accept.Location = new System.Drawing.Point(64, 60);
            this.B_accept.Name = "B_accept";
            this.B_accept.Size = new System.Drawing.Size(100, 50);
            this.B_accept.TabIndex = 0;
            this.B_accept.Text = "Accept";
            this.B_accept.UseVisualStyleBackColor = true;
            this.B_accept.Click += new System.EventHandler(this.B_accept_Click);
            // 
            // B_decline
            // 
            this.B_decline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_decline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_decline.Location = new System.Drawing.Point(292, 60);
            this.B_decline.Name = "B_decline";
            this.B_decline.Size = new System.Drawing.Size(100, 50);
            this.B_decline.TabIndex = 1;
            this.B_decline.Text = "Decline";
            this.B_decline.UseVisualStyleBackColor = true;
            this.B_decline.Click += new System.EventHandler(this.B_decline_Click);
            // 
            // L_EULA
            // 
            this.L_EULA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_EULA.AutoSize = true;
            this.L_EULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_EULA.Location = new System.Drawing.Point(11, 15);
            this.L_EULA.Name = "L_EULA";
            this.L_EULA.Size = new System.Drawing.Size(440, 31);
            this.L_EULA.TabIndex = 1;
            this.L_EULA.Text = "D3 End-User License Agreement";
            // 
            // rTB_EULA
            // 
            this.rTB_EULA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rTB_EULA.Location = new System.Drawing.Point(33, 81);
            this.rTB_EULA.Name = "rTB_EULA";
            this.rTB_EULA.ReadOnly = true;
            this.rTB_EULA.Size = new System.Drawing.Size(395, 226);
            this.rTB_EULA.TabIndex = 2;
            this.rTB_EULA.Text = resources.GetString("rTB_EULA.Text");
            // 
            // EULA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 527);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EULA";
            this.Text = "EULA";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button B_accept;
        private System.Windows.Forms.Label L_EULA;
        private System.Windows.Forms.Button B_decline;
        private System.Windows.Forms.RichTextBox rTB_EULA;
    }
}