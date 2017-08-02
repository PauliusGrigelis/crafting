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
        public PictureBox tempSlot = new PictureBox();
        public PictureBox itemOnDrag;
        public PictureBox itemSender;
        public PictureBox itemReceiver;

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
            item1.AllowDrop = true;
            item2.AllowDrop = true;
            item3.AllowDrop = true;
            item4.AllowDrop = true;
            item5.AllowDrop = true;
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

        private void doubleClick(object sender, EventArgs e)
        {
            slot = parentForm.getFreeSlot();
            itemSender = (PictureBox)sender;
            if (itemSender != null && slot != null)
            {
                parentForm.getFreeSlot().ImageLocation = this.itemSender.ImageLocation;
                this.itemSender = null;
            }
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            itemSender = (PictureBox)sender;
            tempSlot.ImageLocation = itemSender.ImageLocation;
            itemOnDrag = itemSender;
            if (itemSender.ImageLocation == null) return;
            if (DoDragDrop(itemSender.ImageLocation, DragDropEffects.Move) == DragDropEffects.Move)
            {
            }
        }
        private void mouseUp(object sender, MouseEventArgs e)
        {
            tempSlot.ImageLocation = null;
            itemOnDrag = null;
        }

        private void dragEnter(object sender, DragEventArgs e)
        {
            itemReceiver = (PictureBox)sender;
            e.Effect = DragDropEffects.Move;
            itemReceiver.BorderStyle = BorderStyle.Fixed3D;
        }

        private void dragDrop(object sender, DragEventArgs e)
        {
            itemOnDrag.BorderStyle = BorderStyle.None;
            itemReceiver.BorderStyle = BorderStyle.None;
            itemOnDrag.ImageLocation = itemReceiver.ImageLocation;
            itemReceiver.ImageLocation = tempSlot.ImageLocation;
            this.Cursor = Cursors.Default;
        }
    }
}
