namespace SmashTacker
{
    partial class form_main
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
            this.btn_battle = new System.Windows.Forms.Button();
            this.btn_rankings = new System.Windows.Forms.Button();
            this.btn_newChallenger = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_battle
            // 
            this.btn_battle.Location = new System.Drawing.Point(255, 91);
            this.btn_battle.Name = "btn_battle";
            this.btn_battle.Size = new System.Drawing.Size(209, 68);
            this.btn_battle.TabIndex = 0;
            this.btn_battle.Text = "Battle";
            this.btn_battle.UseVisualStyleBackColor = true;
            this.btn_battle.Click += new System.EventHandler(this.Btn_battle_Click);
            // 
            // btn_rankings
            // 
            this.btn_rankings.Location = new System.Drawing.Point(255, 165);
            this.btn_rankings.Name = "btn_rankings";
            this.btn_rankings.Size = new System.Drawing.Size(101, 43);
            this.btn_rankings.TabIndex = 1;
            this.btn_rankings.Text = "Rankings";
            this.btn_rankings.UseVisualStyleBackColor = true;
            this.btn_rankings.Click += new System.EventHandler(this.Btn_rankings_Click);
            // 
            // btn_newChallenger
            // 
            this.btn_newChallenger.Location = new System.Drawing.Point(362, 165);
            this.btn_newChallenger.Name = "btn_newChallenger";
            this.btn_newChallenger.Size = new System.Drawing.Size(101, 43);
            this.btn_newChallenger.TabIndex = 2;
            this.btn_newChallenger.Text = "New Challenger";
            this.btn_newChallenger.UseVisualStyleBackColor = true;
            this.btn_newChallenger.Click += new System.EventHandler(this.Btn_newChallenger_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(120, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 117);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 310);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_newChallenger);
            this.Controls.Add(this.btn_rankings);
            this.Controls.Add(this.btn_battle);
            this.Name = "form_main";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_battle;
        private System.Windows.Forms.Button btn_rankings;
        private System.Windows.Forms.Button btn_newChallenger;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

