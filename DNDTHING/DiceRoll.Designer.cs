namespace DNDTHING
{
    partial class DiceRoll
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.Button();
            this.RollButt = new System.Windows.Forms.Button();
            this.DiceBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.DimGray;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(728, 1769);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(352, 148);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MAIN MENU";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // RollButt
            // 
            this.RollButt.BackColor = System.Drawing.Color.DimGray;
            this.RollButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButt.Location = new System.Drawing.Point(365, 1064);
            this.RollButt.Name = "RollButt";
            this.RollButt.Size = new System.Drawing.Size(352, 148);
            this.RollButt.TabIndex = 2;
            this.RollButt.Text = "ROLL";
            this.RollButt.UseVisualStyleBackColor = false;
            this.RollButt.Click += new System.EventHandler(this.RollButt_Click);
            // 
            // DiceBox
            // 
            this.DiceBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DiceBox.Location = new System.Drawing.Point(322, 501);
            this.DiceBox.Name = "DiceBox";
            this.DiceBox.Size = new System.Drawing.Size(450, 529);
            this.DiceBox.TabIndex = 3;
            this.DiceBox.TabStop = false;
            // 
            // DiceRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DNDTHING.Properties.Resources.MainMenu1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.DiceBox);
            this.Controls.Add(this.RollButt);
            this.Controls.Add(this.MainMenu);
            this.Name = "DiceRoll";
            this.Size = new System.Drawing.Size(1080, 1920);
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button RollButt;
        private System.Windows.Forms.PictureBox DiceBox;
    }
}
