namespace Wizard_Duel
{
    partial class Versus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Versus));
            this.versusPlayArea = new System.Windows.Forms.SplitContainer();
            this.removeEnemyHealth = new System.Windows.Forms.Button();
            this.enemySpellbook = new System.Windows.Forms.Panel();
            this.enemyCasts = new System.Windows.Forms.Label();
            this.castsRemainingTextEnemy = new System.Windows.Forms.Label();
            this.enemyHealth = new System.Windows.Forms.Label();
            this.opponentName = new System.Windows.Forms.Label();
            this.removePlayerHealth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerSpellbook = new System.Windows.Forms.Panel();
            this.playerCasts = new System.Windows.Forms.Label();
            this.castsRemainingTextPlayer = new System.Windows.Forms.Label();
            this.playerHealth = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.versusPlayArea)).BeginInit();
            this.versusPlayArea.Panel1.SuspendLayout();
            this.versusPlayArea.Panel2.SuspendLayout();
            this.versusPlayArea.SuspendLayout();
            this.enemySpellbook.SuspendLayout();
            this.playerSpellbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // versusPlayArea
            // 
            this.versusPlayArea.BackColor = System.Drawing.SystemColors.Info;
            this.versusPlayArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.versusPlayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versusPlayArea.Location = new System.Drawing.Point(0, 0);
            this.versusPlayArea.Name = "versusPlayArea";
            this.versusPlayArea.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // versusPlayArea.Panel1
            // 
            this.versusPlayArea.Panel1.Controls.Add(this.removeEnemyHealth);
            this.versusPlayArea.Panel1.Controls.Add(this.enemySpellbook);
            this.versusPlayArea.Panel1.Controls.Add(this.enemyHealth);
            this.versusPlayArea.Panel1.Controls.Add(this.opponentName);
            this.versusPlayArea.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusPlayArea.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.versusPlayArea_Panel1_Paint);
            // 
            // versusPlayArea.Panel2
            // 
            this.versusPlayArea.Panel2.Controls.Add(this.removePlayerHealth);
            this.versusPlayArea.Panel2.Controls.Add(this.label1);
            this.versusPlayArea.Panel2.Controls.Add(this.playerSpellbook);
            this.versusPlayArea.Panel2.Controls.Add(this.playerHealth);
            this.versusPlayArea.Panel2.Controls.Add(this.playerName);
            this.versusPlayArea.Size = new System.Drawing.Size(1343, 620);
            this.versusPlayArea.SplitterDistance = 319;
            this.versusPlayArea.SplitterWidth = 1;
            this.versusPlayArea.TabIndex = 0;
            // 
            // removeEnemyHealth
            // 
            this.removeEnemyHealth.Location = new System.Drawing.Point(485, 78);
            this.removeEnemyHealth.Name = "removeEnemyHealth";
            this.removeEnemyHealth.Size = new System.Drawing.Size(322, 99);
            this.removeEnemyHealth.TabIndex = 3;
            this.removeEnemyHealth.Text = "REMOVE HEALTH";
            this.removeEnemyHealth.UseVisualStyleBackColor = true;
            this.removeEnemyHealth.Click += new System.EventHandler(this.removeEnemyHealth_Click);
            // 
            // enemySpellbook
            // 
            this.enemySpellbook.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.enemySpellbook.Controls.Add(this.enemyCasts);
            this.enemySpellbook.Controls.Add(this.castsRemainingTextEnemy);
            this.enemySpellbook.Location = new System.Drawing.Point(12, 64);
            this.enemySpellbook.Name = "enemySpellbook";
            this.enemySpellbook.Size = new System.Drawing.Size(118, 162);
            this.enemySpellbook.TabIndex = 2;
            // 
            // enemyCasts
            // 
            this.enemyCasts.AutoSize = true;
            this.enemyCasts.Location = new System.Drawing.Point(26, 14);
            this.enemyCasts.Name = "enemyCasts";
            this.enemyCasts.Size = new System.Drawing.Size(71, 37);
            this.enemyCasts.TabIndex = 1;
            this.enemyCasts.Text = "000";
            // 
            // castsRemainingTextEnemy
            // 
            this.castsRemainingTextEnemy.AutoSize = true;
            this.castsRemainingTextEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castsRemainingTextEnemy.Location = new System.Drawing.Point(10, 51);
            this.castsRemainingTextEnemy.Name = "castsRemainingTextEnemy";
            this.castsRemainingTextEnemy.Size = new System.Drawing.Size(101, 15);
            this.castsRemainingTextEnemy.TabIndex = 0;
            this.castsRemainingTextEnemy.Text = "Casts Remaining";
            // 
            // enemyHealth
            // 
            this.enemyHealth.AutoSize = true;
            this.enemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHealth.Location = new System.Drawing.Point(38, 252);
            this.enemyHealth.Name = "enemyHealth";
            this.enemyHealth.Size = new System.Drawing.Size(55, 39);
            this.enemyHealth.TabIndex = 1;
            this.enemyHealth.Text = "00";
            this.enemyHealth.Click += new System.EventHandler(this.label1_Click);
            // 
            // opponentName
            // 
            this.opponentName.AutoSize = true;
            this.opponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.opponentName.Location = new System.Drawing.Point(8, 23);
            this.opponentName.Name = "opponentName";
            this.opponentName.Size = new System.Drawing.Size(66, 24);
            this.opponentName.TabIndex = 0;
            this.opponentName.Text = "NAME";
            // 
            // removePlayerHealth
            // 
            this.removePlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.removePlayerHealth.Location = new System.Drawing.Point(485, 97);
            this.removePlayerHealth.Name = "removePlayerHealth";
            this.removePlayerHealth.Size = new System.Drawing.Size(322, 99);
            this.removePlayerHealth.TabIndex = 4;
            this.removePlayerHealth.Text = "REMOVE HEALTH";
            this.removePlayerHealth.UseVisualStyleBackColor = true;
            this.removePlayerHealth.Click += new System.EventHandler(this.removePlayerHealth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2812, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // playerSpellbook
            // 
            this.playerSpellbook.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.playerSpellbook.Controls.Add(this.playerCasts);
            this.playerSpellbook.Controls.Add(this.castsRemainingTextPlayer);
            this.playerSpellbook.Location = new System.Drawing.Point(12, 87);
            this.playerSpellbook.Name = "playerSpellbook";
            this.playerSpellbook.Size = new System.Drawing.Size(118, 162);
            this.playerSpellbook.TabIndex = 3;
            // 
            // playerCasts
            // 
            this.playerCasts.AutoSize = true;
            this.playerCasts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCasts.Location = new System.Drawing.Point(26, 10);
            this.playerCasts.Name = "playerCasts";
            this.playerCasts.Size = new System.Drawing.Size(71, 37);
            this.playerCasts.TabIndex = 2;
            this.playerCasts.Text = "000";
            // 
            // castsRemainingTextPlayer
            // 
            this.castsRemainingTextPlayer.AutoSize = true;
            this.castsRemainingTextPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castsRemainingTextPlayer.Location = new System.Drawing.Point(10, 47);
            this.castsRemainingTextPlayer.Name = "castsRemainingTextPlayer";
            this.castsRemainingTextPlayer.Size = new System.Drawing.Size(101, 15);
            this.castsRemainingTextPlayer.TabIndex = 1;
            this.castsRemainingTextPlayer.Text = "Casts Remaining";
            // 
            // playerHealth
            // 
            this.playerHealth.AutoSize = true;
            this.playerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealth.Location = new System.Drawing.Point(38, 29);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(55, 39);
            this.playerHealth.TabIndex = 2;
            this.playerHealth.Text = "00";
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.playerName.Location = new System.Drawing.Point(12, 267);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(66, 24);
            this.playerName.TabIndex = 2;
            this.playerName.Text = "NAME";
            // 
            // Versus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 620);
            this.Controls.Add(this.versusPlayArea);
            this.Name = "Versus";
            this.Text = "VERSUS";
            this.Load += new System.EventHandler(this.Versus_Load);
            this.versusPlayArea.Panel1.ResumeLayout(false);
            this.versusPlayArea.Panel1.PerformLayout();
            this.versusPlayArea.Panel2.ResumeLayout(false);
            this.versusPlayArea.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versusPlayArea)).EndInit();
            this.versusPlayArea.ResumeLayout(false);
            this.enemySpellbook.ResumeLayout(false);
            this.enemySpellbook.PerformLayout();
            this.playerSpellbook.ResumeLayout(false);
            this.playerSpellbook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer versusPlayArea;
        private System.Windows.Forms.Label enemyHealth;
        private System.Windows.Forms.Label opponentName;
        private System.Windows.Forms.Label playerHealth;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Panel enemySpellbook;
        private System.Windows.Forms.Panel playerSpellbook;
        private System.Windows.Forms.Label castsRemainingTextEnemy;
        private System.Windows.Forms.Label castsRemainingTextPlayer;
        private System.Windows.Forms.Label enemyCasts;
        private System.Windows.Forms.Label playerCasts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeEnemyHealth;
        private System.Windows.Forms.Button removePlayerHealth;
    }
}