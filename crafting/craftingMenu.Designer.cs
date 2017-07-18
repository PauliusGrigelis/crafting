namespace crafting
{
    partial class craftingMenu
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
            this.craftButton = new System.Windows.Forms.Button();
            this.item1 = new System.Windows.Forms.PictureBox();
            this.craftingPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            this.craftingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // craftButton
            // 
            this.craftButton.Location = new System.Drawing.Point(143, 337);
            this.craftButton.Name = "craftButton";
            this.craftButton.Size = new System.Drawing.Size(138, 38);
            this.craftButton.TabIndex = 1;
            this.craftButton.Text = "Craft";
            this.craftButton.UseVisualStyleBackColor = true;
            this.craftButton.Click += new System.EventHandler(this.craftButton_Click);
            // 
            // item1
            // 
            this.item1.Location = new System.Drawing.Point(0, 0);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(50, 50);
            this.item1.TabIndex = 2;
            this.item1.TabStop = false;
            // 
            // panel1
            // 
            this.craftingPanel.Controls.Add(this.item1);
            this.craftingPanel.Location = new System.Drawing.Point(13, 13);
            this.craftingPanel.Name = "craftingPanel";
            this.craftingPanel.Size = new System.Drawing.Size(395, 318);
            this.craftingPanel.TabIndex = 3;
            // 
            // craftingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 481);
            this.Controls.Add(this.craftingPanel);
            this.Controls.Add(this.craftButton);
            this.Name = "craftingMenu";
            this.Text = "crafting menu";
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            this.craftingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button craftButton;
        public System.Windows.Forms.PictureBox item1;
        private System.Windows.Forms.Panel craftingPanel;
    }
}

