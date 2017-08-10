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
using crafting.Other;

namespace crafting
{
    public partial class Inventory : Form
    {
        private readonly DataContext Context;

        craftingMenu parentForm;
        PictureBox slot = new PictureBox();
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
                    if (TransferItem.itemSender != null && slot != null)
                    {
                        parentForm.getFreeSlot().ImageLocation = TransferItem.itemSender.ImageLocation;
                        TransferItem.itemSender.ImageLocation = null;
                        TransferItem.tempSlot.ImageLocation = null;
                        TransferItem.itemSender = null;
                    }
                }
                else
                {
                    TransferItem.tempSlot.ImageLocation = TransferItem.itemSender.ImageLocation;
                    DoDragDrop(TransferItem.itemSender.ImageLocation, DragDropEffects.Move);
                    TransferItem.itemSender.BorderStyle = BorderStyle.None;
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
                TransferItem.itemSender = (PictureBox)sender;
                if (TransferItem.itemSender.ImageLocation == null) return;
                TransferItem.itemSender.BorderStyle = BorderStyle.Fixed3D;
                isFirstClick = false;
                timer.Start();
            }
            else
            {
                if(milliseconds < 150)
                    isDoubleClick = true;
                TransferItem.itemSender.BorderStyle = BorderStyle.None;
            }
        }

        private void dragEnter(object sender, DragEventArgs e)
        {
            TransferItem.itemReceiver = (PictureBox)sender;
            e.Effect = DragDropEffects.Move;
            TransferItem.itemReceiver.BorderStyle = BorderStyle.Fixed3D;
        }

        private void dragDrop(object sender, DragEventArgs e)
        {
            TransferItem.itemSender.BorderStyle = BorderStyle.None;
            TransferItem.itemReceiver.BorderStyle = BorderStyle.None;
            TransferItem.itemSender.ImageLocation = TransferItem.itemReceiver.ImageLocation;
            TransferItem.itemReceiver.ImageLocation = TransferItem.tempSlot.ImageLocation;
            this.Cursor = Cursors.Default;
            e.Effect = DragDropEffects.None;
        }

        private void dragLeave(object sender, EventArgs e)
        {
            if(TransferItem.itemReceiver.ImageLocation != TransferItem.itemSender.ImageLocation)
                TransferItem.itemReceiver.BorderStyle = BorderStyle.None;
        }
    }
}
