namespace crafting
{
    partial class Inventory
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
            this.goldLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemContainer = new System.Windows.Forms.Panel();
            this.item1 = new System.Windows.Forms.PictureBox();
            this.item2 = new System.Windows.Forms.PictureBox();
            this.item3 = new System.Windows.Forms.PictureBox();
            this.item4 = new System.Windows.Forms.PictureBox();
            this.item5 = new System.Windows.Forms.PictureBox();
            this.item6 = new System.Windows.Forms.PictureBox();
            this.item7 = new System.Windows.Forms.PictureBox();
            this.item8 = new System.Windows.Forms.PictureBox();
            this.item9 = new System.Windows.Forms.PictureBox();
            this.item10 = new System.Windows.Forms.PictureBox();
            this.itemContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item10)).BeginInit();
            this.SuspendLayout();
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.Location = new System.Drawing.Point(257, 439);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(42, 17);
            this.goldLabel.TabIndex = 2;
            this.goldLabel.Text = "Gold:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // itemContainer
            // 
            this.itemContainer.Controls.Add(this.item1);
            this.itemContainer.Controls.Add(this.item2);
            this.itemContainer.Controls.Add(this.item3);
            this.itemContainer.Controls.Add(this.item4);
            this.itemContainer.Controls.Add(this.item5);
            this.itemContainer.Controls.Add(this.item6);
            this.itemContainer.Controls.Add(this.item7);
            this.itemContainer.Controls.Add(this.item8);
            this.itemContainer.Controls.Add(this.item9);
            this.itemContainer.Controls.Add(this.item10);
            this.itemContainer.Location = new System.Drawing.Point(13, 13);
            this.itemContainer.Name = "itemContainer";
            this.itemContainer.Size = new System.Drawing.Size(344, 405);
            this.itemContainer.TabIndex = 4;
            // 
            // item1
            // 
            this.item1.Location = new System.Drawing.Point(0, 0);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(50, 50);
            this.item1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item1.TabIndex = 0;
            this.item1.TabStop = false;
            this.item1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.item1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.item1.DoubleClick += new System.EventHandler(this.item1_DoubleClick);
            this.item1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.item1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // item2
            // 
            this.item2.Location = new System.Drawing.Point(50, 0);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(50, 50);
            this.item2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item2.TabIndex = 0;
            this.item2.TabStop = false;
            this.item2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.item2.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.item2.DoubleClick += new System.EventHandler(this.item2_DoubleClick);
            this.item2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            // 
            // item3
            // 
            this.item3.Location = new System.Drawing.Point(100, 0);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(50, 50);
            this.item3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item3.TabIndex = 0;
            this.item3.TabStop = false;
            this.item3.DoubleClick += new System.EventHandler(this.item3_DoubleClick);
            // 
            // item4
            // 
            this.item4.Location = new System.Drawing.Point(150, 0);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(50, 50);
            this.item4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item4.TabIndex = 0;
            this.item4.TabStop = false;
            this.item4.DoubleClick += new System.EventHandler(this.item4_DoubleClick);
            // 
            // item5
            // 
            this.item5.Location = new System.Drawing.Point(200, 0);
            this.item5.Name = "item5";
            this.item5.Size = new System.Drawing.Size(50, 50);
            this.item5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item5.TabIndex = 0;
            this.item5.TabStop = false;
            this.item5.DoubleClick += new System.EventHandler(this.item5_DoubleClick);
            // 
            // item6
            // 
            this.item6.Location = new System.Drawing.Point(250, 0);
            this.item6.Name = "item6";
            this.item6.Size = new System.Drawing.Size(50, 50);
            this.item6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item6.TabIndex = 0;
            this.item6.TabStop = false;
            // 
            // item7
            // 
            this.item7.Location = new System.Drawing.Point(0, 50);
            this.item7.Name = "item7";
            this.item7.Size = new System.Drawing.Size(50, 50);
            this.item7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item7.TabIndex = 0;
            this.item7.TabStop = false;
            // 
            // item8
            // 
            this.item8.Location = new System.Drawing.Point(50, 50);
            this.item8.Name = "item8";
            this.item8.Size = new System.Drawing.Size(50, 50);
            this.item8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item8.TabIndex = 0;
            this.item8.TabStop = false;
            // 
            // item9
            // 
            this.item9.Location = new System.Drawing.Point(100, 50);
            this.item9.Name = "item9";
            this.item9.Size = new System.Drawing.Size(50, 50);
            this.item9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item9.TabIndex = 0;
            this.item9.TabStop = false;
            // 
            // item10
            // 
            this.item10.Location = new System.Drawing.Point(150, 50);
            this.item10.Name = "item10";
            this.item10.Size = new System.Drawing.Size(50, 50);
            this.item10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item10.TabIndex = 0;
            this.item10.TabStop = false;
            // 
            // Inventory
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 465);
            this.Controls.Add(this.itemContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goldLabel);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.itemContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel itemContainer;
        public System.Windows.Forms.PictureBox item1;
        public System.Windows.Forms.PictureBox item2;
        public System.Windows.Forms.PictureBox item3;
        public System.Windows.Forms.PictureBox item4;
        public System.Windows.Forms.PictureBox item5;
        public System.Windows.Forms.PictureBox item6;
        public System.Windows.Forms.PictureBox item7;
        public System.Windows.Forms.PictureBox item8;
        public System.Windows.Forms.PictureBox item9;
        public System.Windows.Forms.PictureBox item10;
    }
}