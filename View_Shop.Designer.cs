namespace Shop_Details
{
    partial class Form_View_Shop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.top_heading = new System.Windows.Forms.Label();
            this.dgv_view_records = new System.Windows.Forms.DataGridView();
            this.btn_view_records = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_records)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.top_heading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 52);
            this.panel1.TabIndex = 1;
            // 
            // top_heading
            // 
            this.top_heading.AutoSize = true;
            this.top_heading.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_heading.ForeColor = System.Drawing.Color.White;
            this.top_heading.Location = new System.Drawing.Point(365, 9);
            this.top_heading.Name = "top_heading";
            this.top_heading.Size = new System.Drawing.Size(159, 35);
            this.top_heading.TabIndex = 1;
            this.top_heading.Text = "Shop Details";
            // 
            // dgv_view_records
            // 
            this.dgv_view_records.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgv_view_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_view_records.Location = new System.Drawing.Point(12, 71);
            this.dgv_view_records.Name = "dgv_view_records";
            this.dgv_view_records.RowHeadersWidth = 51;
            this.dgv_view_records.RowTemplate.Height = 24;
            this.dgv_view_records.Size = new System.Drawing.Size(864, 506);
            this.dgv_view_records.TabIndex = 13;
            // 
            // btn_view_records
            // 
            this.btn_view_records.BackColor = System.Drawing.Color.Red;
            this.btn_view_records.FlatAppearance.BorderSize = 0;
            this.btn_view_records.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view_records.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_view_records.ForeColor = System.Drawing.Color.White;
            this.btn_view_records.Location = new System.Drawing.Point(276, 617);
            this.btn_view_records.Name = "btn_view_records";
            this.btn_view_records.Size = new System.Drawing.Size(94, 37);
            this.btn_view_records.TabIndex = 17;
            this.btn_view_records.Text = "Close";
            this.btn_view_records.UseVisualStyleBackColor = false;
            this.btn_view_records.Click += new System.EventHandler(this.btn_view_records_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Green;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(398, 617);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 37);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Gold;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(519, 617);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 37);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form_View_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 688);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_view_records);
            this.Controls.Add(this.dgv_view_records);
            this.Controls.Add(this.panel1);
            this.Name = "Form_View_Shop";
            this.Text = "View_Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label top_heading;
        private System.Windows.Forms.DataGridView dgv_view_records;
        private System.Windows.Forms.Button btn_view_records;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}