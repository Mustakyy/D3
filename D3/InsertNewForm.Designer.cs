namespace D3
{
    partial class InsertNewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertNewForm));
            this.L_insertnew = new System.Windows.Forms.Label();
            this.L_name = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_portion = new System.Windows.Forms.TextBox();
            this.TB_fats = new System.Windows.Forms.TextBox();
            this.TB_proteins = new System.Windows.Forms.TextBox();
            this.L_carbohydrates = new System.Windows.Forms.Label();
            this.L_manufacturer = new System.Windows.Forms.Label();
            this.TB_manufacturer = new System.Windows.Forms.TextBox();
            this.L_kcal100g = new System.Windows.Forms.Label();
            this.TB_kcal100g = new System.Windows.Forms.TextBox();
            this.L_proteins = new System.Windows.Forms.Label();
            this.L_fats = new System.Windows.Forms.Label();
            this.L_portion = new System.Windows.Forms.Label();
            this.TB_carbohydrates = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.B_insert = new System.Windows.Forms.Button();
            this.B_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_insertnew
            // 
            this.L_insertnew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_insertnew.AutoSize = true;
            this.L_insertnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_insertnew.Location = new System.Drawing.Point(198, 15);
            this.L_insertnew.Name = "L_insertnew";
            this.L_insertnew.Size = new System.Drawing.Size(208, 26);
            this.L_insertnew.TabIndex = 0;
            this.L_insertnew.Text = "Insert new product";
            // 
            // L_name
            // 
            this.L_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_name.AutoSize = true;
            this.L_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_name.Location = new System.Drawing.Point(20, 16);
            this.L_name.Name = "L_name";
            this.L_name.Size = new System.Drawing.Size(49, 17);
            this.L_name.TabIndex = 1;
            this.L_name.Text = "Name:";
            // 
            // TB_name
            // 
            this.TB_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_name.Location = new System.Drawing.Point(93, 15);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(183, 20);
            this.TB_name.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.L_insertnew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.34831F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.65169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 347);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel2.Controls.Add(this.TB_portion, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TB_fats, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.TB_proteins, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.L_carbohydrates, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TB_name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.L_name, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.L_manufacturer, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TB_manufacturer, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.L_kcal100g, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TB_kcal100g, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.L_proteins, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.L_fats, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.L_portion, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TB_carbohydrates, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(598, 202);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // TB_portion
            // 
            this.TB_portion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_portion.Location = new System.Drawing.Point(93, 166);
            this.TB_portion.Name = "TB_portion";
            this.TB_portion.Size = new System.Drawing.Size(183, 20);
            this.TB_portion.TabIndex = 14;
            // 
            // TB_fats
            // 
            this.TB_fats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_fats.Location = new System.Drawing.Point(409, 115);
            this.TB_fats.Name = "TB_fats";
            this.TB_fats.Size = new System.Drawing.Size(184, 20);
            this.TB_fats.TabIndex = 13;
            // 
            // TB_proteins
            // 
            this.TB_proteins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_proteins.Location = new System.Drawing.Point(93, 115);
            this.TB_proteins.Name = "TB_proteins";
            this.TB_proteins.Size = new System.Drawing.Size(183, 20);
            this.TB_proteins.TabIndex = 12;
            // 
            // L_carbohydrates
            // 
            this.L_carbohydrates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_carbohydrates.AutoSize = true;
            this.L_carbohydrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_carbohydrates.Location = new System.Drawing.Point(289, 66);
            this.L_carbohydrates.Name = "L_carbohydrates";
            this.L_carbohydrates.Size = new System.Drawing.Size(105, 17);
            this.L_carbohydrates.TabIndex = 8;
            this.L_carbohydrates.Text = "Carbohydrates:";
            // 
            // L_manufacturer
            // 
            this.L_manufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_manufacturer.AutoSize = true;
            this.L_manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_manufacturer.Location = new System.Drawing.Point(294, 16);
            this.L_manufacturer.Name = "L_manufacturer";
            this.L_manufacturer.Size = new System.Drawing.Size(96, 17);
            this.L_manufacturer.TabIndex = 3;
            this.L_manufacturer.Text = "Manufacturer:";
            // 
            // TB_manufacturer
            // 
            this.TB_manufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_manufacturer.Location = new System.Drawing.Point(409, 15);
            this.TB_manufacturer.Name = "TB_manufacturer";
            this.TB_manufacturer.Size = new System.Drawing.Size(184, 20);
            this.TB_manufacturer.TabIndex = 5;
            // 
            // L_kcal100g
            // 
            this.L_kcal100g.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_kcal100g.AutoSize = true;
            this.L_kcal100g.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_kcal100g.Location = new System.Drawing.Point(8, 66);
            this.L_kcal100g.Name = "L_kcal100g";
            this.L_kcal100g.Size = new System.Drawing.Size(73, 17);
            this.L_kcal100g.TabIndex = 4;
            this.L_kcal100g.Text = "kcal/100g:";
            // 
            // TB_kcal100g
            // 
            this.TB_kcal100g.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_kcal100g.Location = new System.Drawing.Point(93, 65);
            this.TB_kcal100g.Name = "TB_kcal100g";
            this.TB_kcal100g.Size = new System.Drawing.Size(183, 20);
            this.TB_kcal100g.TabIndex = 6;
            // 
            // L_proteins
            // 
            this.L_proteins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_proteins.AutoSize = true;
            this.L_proteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_proteins.Location = new System.Drawing.Point(13, 116);
            this.L_proteins.Name = "L_proteins";
            this.L_proteins.Size = new System.Drawing.Size(64, 17);
            this.L_proteins.TabIndex = 7;
            this.L_proteins.Text = "Proteins:";
            // 
            // L_fats
            // 
            this.L_fats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_fats.AutoSize = true;
            this.L_fats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_fats.Location = new System.Drawing.Point(322, 116);
            this.L_fats.Name = "L_fats";
            this.L_fats.Size = new System.Drawing.Size(39, 17);
            this.L_fats.TabIndex = 9;
            this.L_fats.Text = "Fats:";
            // 
            // L_portion
            // 
            this.L_portion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_portion.AutoSize = true;
            this.L_portion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_portion.Location = new System.Drawing.Point(16, 167);
            this.L_portion.Name = "L_portion";
            this.L_portion.Size = new System.Drawing.Size(57, 17);
            this.L_portion.TabIndex = 10;
            this.L_portion.Text = "Portion:";
            // 
            // TB_carbohydrates
            // 
            this.TB_carbohydrates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_carbohydrates.Location = new System.Drawing.Point(409, 65);
            this.TB_carbohydrates.Name = "TB_carbohydrates";
            this.TB_carbohydrates.Size = new System.Drawing.Size(184, 20);
            this.TB_carbohydrates.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.B_insert, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.B_cancel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 267);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(598, 77);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // B_insert
            // 
            this.B_insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_insert.Location = new System.Drawing.Point(84, 27);
            this.B_insert.Name = "B_insert";
            this.B_insert.Size = new System.Drawing.Size(130, 23);
            this.B_insert.TabIndex = 0;
            this.B_insert.Text = "Insert";
            this.B_insert.UseVisualStyleBackColor = true;
            this.B_insert.Click += new System.EventHandler(this.B_insert_Click);
            // 
            // B_cancel
            // 
            this.B_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_cancel.Location = new System.Drawing.Point(383, 27);
            this.B_cancel.Name = "B_cancel";
            this.B_cancel.Size = new System.Drawing.Size(130, 23);
            this.B_cancel.TabIndex = 1;
            this.B_cancel.Text = "Cancel";
            this.B_cancel.UseVisualStyleBackColor = true;
            this.B_cancel.Click += new System.EventHandler(this.B_cancel_Click);
            // 
            // InsertNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 347);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertNewForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label L_insertnew;
        private System.Windows.Forms.Label L_name;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label L_manufacturer;
        private System.Windows.Forms.Label L_kcal100g;
        private System.Windows.Forms.TextBox TB_manufacturer;
        private System.Windows.Forms.TextBox TB_kcal100g;
        private System.Windows.Forms.Label L_proteins;
        private System.Windows.Forms.Label L_carbohydrates;
        private System.Windows.Forms.Label L_fats;
        private System.Windows.Forms.Label L_portion;
        private System.Windows.Forms.TextBox TB_portion;
        private System.Windows.Forms.TextBox TB_fats;
        private System.Windows.Forms.TextBox TB_proteins;
        private System.Windows.Forms.TextBox TB_carbohydrates;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button B_insert;
        private System.Windows.Forms.Button B_cancel;
    }
}