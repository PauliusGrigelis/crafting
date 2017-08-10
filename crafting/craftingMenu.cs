﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crafting.Other;

namespace crafting
{
    public partial class craftingMenu : Form
    {
        Inventory inventoryForm;
        PictureBox slot = new PictureBox();
        Timer timer = new Timer();
        bool isFirstClick = true;
        bool isDoubleClick = false;
        int milliseconds = 0;

        public craftingMenu()
        {
            InitializeComponent();
            this.Location = new Point(100, 100);
            inventoryForm = new Inventory(this);
            inventoryForm.Show();
            inventoryForm.Location = new Point(200 + this.Width, this.Location.Y);

            item1.AllowDrop = true;
            item2.AllowDrop = true;
            item3.AllowDrop = true;

            timer.Interval = 150;
            timer.Tick += new EventHandler(timer_Tick);
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

        private void item1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            item1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void item1_DragDrop(object sender, DragEventArgs e)
        {
            item1.BorderStyle = BorderStyle.None;
            inventoryForm.item1.ImageLocation = item1.ImageLocation;
            item1.ImageLocation = TransferItem.tempSlot.ImageLocation;
            this.Cursor = Cursors.Default;
        }


        void timer_Tick(object sender, EventArgs e)
        {
            milliseconds += 150;

            if (milliseconds >= 150)
            {
                timer.Stop();
                if (isDoubleClick)
                {
                    slot = inventoryForm.getFreeSlot();
                    if (TransferItem.itemSender != null && slot != null)
                    {
                        inventoryForm.getFreeSlot().ImageLocation = TransferItem.itemSender.ImageLocation;
                        TransferItem.itemSender.ImageLocation = null;
                        TransferItem.tempSlot.ImageLocation = null;
                        TransferItem.itemSender = null;
                    }
                }
                else
                {
                    TransferItem.tempSlot.ImageLocation = TransferItem.itemSender.ImageLocation;
                    //itemOnDrag = itemSender;
                    //itemOnDrag.BorderStyle = BorderStyle.None;
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
                if (milliseconds < 150)
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
            if (TransferItem.itemReceiver.ImageLocation != TransferItem.itemSender.ImageLocation)
                TransferItem.itemReceiver.BorderStyle = BorderStyle.None;
        }
    }
}
