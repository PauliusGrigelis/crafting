using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crafting
{
    public partial class craftingMenu : Form
    {
        Inventory inventoryForm;
        PictureBox slot = new PictureBox();

        public craftingMenu()
        {
            InitializeComponent();
            this.Location = new Point(100, 100);
            inventoryForm = new Inventory(this);
            inventoryForm.Show();
            inventoryForm.Location = new Point(200 + this.Width, this.Location.Y);
        }

        private void craftButton_Click(object sender, EventArgs e)
        {

        }

        public PictureBox getFreeSlot()
        {
            foreach (PictureBox pb in craftingPanel.Controls.OfType<PictureBox>().ToList())
            {
                if (pb.ImageLocation == null)
                {
                    return pb;
                }
            }
            return null;
        }

        private void item1_DoubleClick(object sender, EventArgs e)
        {
            slot = inventoryForm.getFreeSlot();
            if (item1.ImageLocation != null && slot != null)
            {
                slot.ImageLocation = this.item1.ImageLocation;
                this.item1.ImageLocation = null;
            }
        }

        private void item2_DoubleClick(object sender, EventArgs e)
        {
            slot = inventoryForm.getFreeSlot();
            if (item2.ImageLocation != null && slot != null)
            {
                inventoryForm.getFreeSlot().ImageLocation = this.item2.ImageLocation;
                this.item2.ImageLocation = null;
            }
        }

        private void item3_DoubleClick(object sender, EventArgs e)
        {
            slot = inventoryForm.getFreeSlot();
            if (item3.ImageLocation != null && slot != null)
            {
                inventoryForm.getFreeSlot().ImageLocation = this.item3.ImageLocation;
                this.item3.ImageLocation = null;
            }
        }
    }
}
