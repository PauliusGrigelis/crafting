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
    public partial class Inventory : Form
    {
        craftingMenu parentForm;
        PictureBox slot = new PictureBox();

        public Inventory(Form parentForm)
        {
            this.parentForm = (craftingMenu)parentForm;
            InitializeComponent();
            // Iventory fill for debug purposes:
            item1.ImageLocation = @"./item_icons/boots.png";
            item2.ImageLocation = @"./item_icons/crap.jpg";
            item3.ImageLocation = @"./item_icons/logo.png";
            item4.ImageLocation = @"./item_icons/rock.png";
            item5.ImageLocation = @"./item_icons/water.png";
        }

        public PictureBox getFreeSlot()
        {
            foreach (PictureBox pb in itemContainer.Controls.OfType<PictureBox>().ToList())
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
            slot = parentForm.getFreeSlot();
            if (item1.ImageLocation != null && slot != null)
            {
                slot.ImageLocation = this.item1.ImageLocation;
                this.item1.ImageLocation = null;
            }
        }

        private void item2_DoubleClick(object sender, EventArgs e)
        {
            slot = parentForm.getFreeSlot();
            if (item2.ImageLocation != null && slot != null)
            {
                parentForm.getFreeSlot().ImageLocation = this.item2.ImageLocation;
                this.item2.ImageLocation = null;
            }
        }

        private void item3_DoubleClick(object sender, EventArgs e)
        {
            slot = parentForm.getFreeSlot();
            if (item3.ImageLocation != null && slot != null)
            {
                parentForm.getFreeSlot().ImageLocation = this.item3.ImageLocation;
                this.item3.ImageLocation = null;
            }
        }

        private void item4_DoubleClick(object sender, EventArgs e)
        {
            slot = parentForm.getFreeSlot();
            if (item4.ImageLocation != null && slot != null)
            {
                parentForm.getFreeSlot().ImageLocation = this.item4.ImageLocation;
                this.item4.ImageLocation = null;
            }
        }

        private void item5_DoubleClick(object sender, EventArgs e)
        {
            slot = parentForm.getFreeSlot();
            if (item5.ImageLocation != null && slot != null)
            {
                parentForm.getFreeSlot().ImageLocation = this.item5.ImageLocation;
                this.item5.ImageLocation = null;
            }
        }
    }
}
