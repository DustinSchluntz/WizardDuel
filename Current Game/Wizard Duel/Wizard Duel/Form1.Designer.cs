namespace Wizard_Duel
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
            this.startCampaignBtn = new System.Windows.Forms.Button();
            this.startArenaBtn = new System.Windows.Forms.Button();
            this.startVersusBtn = new System.Windows.Forms.Button();
            this.startChaosBtn = new System.Windows.Forms.Button();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startCampaignBtn
            // 
            this.startCampaignBtn.Location = new System.Drawing.Point(12, 12);
            this.startCampaignBtn.Name = "startCampaignBtn";
            this.startCampaignBtn.Size = new System.Drawing.Size(223, 23);
            this.startCampaignBtn.TabIndex = 0;
            this.startCampaignBtn.Text = "CAMPAIGN";
            this.startCampaignBtn.UseVisualStyleBackColor = true;
            this.startCampaignBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // startArenaBtn
            // 
            this.startArenaBtn.Location = new System.Drawing.Point(12, 41);
            this.startArenaBtn.Name = "startArenaBtn";
            this.startArenaBtn.Size = new System.Drawing.Size(223, 23);
            this.startArenaBtn.TabIndex = 1;
            this.startArenaBtn.Text = "ARENA";
            this.startArenaBtn.UseVisualStyleBackColor = true;
            this.startArenaBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // startVersusBtn
            // 
            this.startVersusBtn.Location = new System.Drawing.Point(12, 70);
            this.startVersusBtn.Name = "startVersusBtn";
            this.startVersusBtn.Size = new System.Drawing.Size(223, 23);
            this.startVersusBtn.TabIndex = 2;
            this.startVersusBtn.Text = "VERSUS";
            this.startVersusBtn.UseVisualStyleBackColor = true;
            this.startVersusBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // startChaosBtn
            // 
            this.startChaosBtn.Location = new System.Drawing.Point(12, 99);
            this.startChaosBtn.Name = "startChaosBtn";
            this.startChaosBtn.Size = new System.Drawing.Size(223, 23);
            this.startChaosBtn.TabIndex = 3;
            this.startChaosBtn.Text = "CHAOS MODE";
            this.startChaosBtn.UseVisualStyleBackColor = true;
            this.startChaosBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // optionsBtn
            // 
            this.optionsBtn.Location = new System.Drawing.Point(12, 128);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(223, 23);
            this.optionsBtn.TabIndex = 4;
            this.optionsBtn.Text = "OPTIONS";
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 157);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(223, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "EXIT GAME";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 188);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.startChaosBtn);
            this.Controls.Add(this.startVersusBtn);
            this.Controls.Add(this.startArenaBtn);
            this.Controls.Add(this.startCampaignBtn);
            this.Name = "Form1";
            this.Text = "WIZARD DUEL";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startCampaignBtn;
        private System.Windows.Forms.Button startArenaBtn;
        private System.Windows.Forms.Button startVersusBtn;
        private System.Windows.Forms.Button startChaosBtn;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

