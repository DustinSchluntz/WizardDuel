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
            this.versusPlayArea = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.versusPlayArea)).BeginInit();
            this.versusPlayArea.SuspendLayout();
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
            this.versusPlayArea.Size = new System.Drawing.Size(1248, 620);
            this.versusPlayArea.SplitterDistance = 310;
            this.versusPlayArea.SplitterWidth = 1;
            this.versusPlayArea.TabIndex = 0;
            // 
            // Versus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 620);
            this.Controls.Add(this.versusPlayArea);
            this.Name = "Versus";
            this.Text = "VERSUS";
            this.Load += new System.EventHandler(this.Versus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.versusPlayArea)).EndInit();
            this.versusPlayArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer versusPlayArea;
    }
}