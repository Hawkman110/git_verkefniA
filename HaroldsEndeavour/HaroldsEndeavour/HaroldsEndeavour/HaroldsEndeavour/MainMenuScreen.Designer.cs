namespace SuperAdventure
{
    partial class MainMenuScreen
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
            this.btPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(169, 232);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(95, 52);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 436);
            this.Controls.Add(this.btPlay);
            this.Name = "MainMenuScreen";
            this.Text = "MainMenuScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPlay;
    }
}