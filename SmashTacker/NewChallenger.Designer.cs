namespace SmashTacker
{
    partial class NewChallenger
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
            this.txtbx_name = new System.Windows.Forms.TextBox();
            this.cmbx_main = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx_name
            // 
            this.txtbx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_name.Location = new System.Drawing.Point(118, 55);
            this.txtbx_name.Name = "txtbx_name";
            this.txtbx_name.Size = new System.Drawing.Size(152, 23);
            this.txtbx_name.TabIndex = 1;
            this.txtbx_name.Tag = "";
            this.txtbx_name.Text = "Enter Name";
            this.txtbx_name.TextChanged += new System.EventHandler(this.Txtbx_name_TextChanged);
            // 
            // cmbx_main
            // 
            this.cmbx_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_main.FormattingEnabled = true;
            this.cmbx_main.Location = new System.Drawing.Point(118, 88);
            this.cmbx_main.Name = "cmbx_main";
            this.cmbx_main.Size = new System.Drawing.Size(152, 24);
            this.cmbx_main.TabIndex = 2;
            this.cmbx_main.Text = "Pick Main";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(298, 133);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(85, 33);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Done";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // form_challenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 168);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbx_main);
            this.Controls.Add(this.txtbx_name);
            this.Name = "form_challenger";
            this.Text = "New Challenger";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_name;
        private System.Windows.Forms.ComboBox cmbx_main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_add;
    }
}