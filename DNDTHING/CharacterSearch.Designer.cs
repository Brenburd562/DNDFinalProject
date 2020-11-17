namespace DNDTHING
{
    partial class CharacterSearch
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
            this.ChaListLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.DimGray;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(725, 1769);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(352, 148);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // ChaListLabel
            // 
            this.ChaListLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChaListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaListLabel.Location = new System.Drawing.Point(0, 479);
            this.ChaListLabel.Name = "ChaListLabel";
            this.ChaListLabel.Size = new System.Drawing.Size(1077, 674);
            this.ChaListLabel.TabIndex = 2;
            this.ChaListLabel.Text = "Characters:";
            this.ChaListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(383, 1586);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(306, 35);
            this.nameInput.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(124, 1559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 82);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search:";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(383, 1624);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 40);
            this.ErrorLabel.TabIndex = 6;
            // 
            // CharacterSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::DNDTHING.Properties.Resources.CharacterList;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.ChaListLabel);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Name = "CharacterSearch";
            this.Size = new System.Drawing.Size(1080, 1920);
            this.Load += new System.EventHandler(this.CharacterSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Label ChaListLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ErrorLabel;
    }
}
