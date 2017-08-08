using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crafting.DataAccess;
using crafting.Repositories;
using crafting.Models;

namespace crafting
{
    public partial class Inventory : Form
    {
        private readonly DataContext Context;

        craftingMenu parentForm;
        PictureBox slot = new PictureBox();
        public PictureBox tempSlot = new PictureBox();
        public PictureBox itemOnDrag;
        public PictureBox itemSender;
        public PictureBox itemReceiver;
        Timer timer = new Timer();
        bool isFirstClick = true;
        bool isDoubleClick = false;
        int milliseconds = 0;

        List<PictureBox> items = new List<PictureBox>();

        public Inventory(Form parentForm)
        {
            this.parentForm = (craftingMenu)parentForm;
            InitializeComponent();

            Context = DataContext.GetContext();

            // Iventory fill for debug purposes:
            items.Add(item1);
            items.Add(item2);
            items.Add(item3);
            items.Add(item4);
            items.Add(item5);
            int i = 0;
            using (var repository = new ItemRepository())
            {
                foreach(Item item in repository.getItems())
                {
                    items[i].ImageLocation = @item.pic;
                    i++;
                }
            }
            item1.AllowDrop = true;
            item2.AllowDrop = true;
            item3.AllowDrop = true;
            item4.AllowDrop = true;
            item5.AllowDrop = true;

            timer.Interval = 150;
            timer.Tick += new EventHandler(timer_Tick);
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

        void timer_Tick(object sender, EventArgs e)
        {
            milliseconds += 150;
            
            if (milliseconds >= 150)
            {
                timer.Stop();
                if (isDoubleClick)
                {
                    slot = parentForm.getFreeSlot();
                    if (itemSender != null && slot != null)
                    {
                        parentForm.getFreeSlot().ImageLocation = this.itemSender.ImageLocation;
                        itemSender.ImageLocation = null;
                        tempSlot.ImageLocation = null;
                        itemOnDrag = null;
                        this.itemSender = null;
                    }
                }
                else
                {
                    tempSlot.ImageLocation = itemSender.ImageLocation;
                    itemOnDrag = itemSender;
                    itemOnDrag.BorderStyle = BorderStyle.None;
                    DoDragDrop(itemSender.ImageLocation, DragDropEffects.Move);
                    itemSender.BorderStyle = BorderStyle.None;
                }
                isFirstClick = true;
                isDoubleClick = false;
                milliseconds = 0;
            }
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            if (isFirstClick)
            {
                itemSender = (PictureBox)sender;
                if (itemSender.ImageLocation == null) return;
                itemSender.BorderStyle = BorderStyle.Fixed3D;
                isFirstClick = false;
                timer.Start();
            }
            else
            {
                if(milliseconds < 150)
                    isDoubleClick = true;
                itemSender.BorderStyle = BorderStyle.None;
            }
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
            e.Effect = DragDropEffects.None;
        }

        private void dragLeave(object sender, EventArgs e)
        {
            //itemReceiver = null;
            if(itemReceiver.ImageLocation != itemSender.ImageLocation)
                itemReceiver.BorderStyle = BorderStyle.None;
        }
    }
}
