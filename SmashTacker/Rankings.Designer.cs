namespace SmashTacker
{
    partial class Rankings
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
            this.dgv_rankings = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rankings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_rankings
            // 
            this.dgv_rankings.AllowUserToAddRows = false;
            this.dgv_rankings.AllowUserToDeleteRows = false;
            this.dgv_rankings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rankings.Location = new System.Drawing.Point(94, 117);
            this.dgv_rankings.Name = "dgv_rankings";
            this.dgv_rankings.ReadOnly = true;
            this.dgv_rankings.Size = new System.Drawing.Size(613, 302);
            this.dgv_rankings.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(304, 55);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(193, 25);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Challenger Rankings";
            // 
            // Rankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dgv_rankings);
            this.Name = "Rankings";
            this.Text = "Rankings";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rankings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rankings;
        private System.Windows.Forms.Label lbl_title;
    }
}