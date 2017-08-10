using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crafting.Other
{
    public static class TransferItem
    {
        public static PictureBox tempSlot { get; set; } = new PictureBox();
        public static PictureBox itemSender { get; set; }
        public static PictureBox itemReceiver { get; set; }

        public static void setTempSlot(PictureBox box)
        {
            tempSlot = box;
        }

        public static void setSender(PictureBox box)
        {
            itemSender = box;
        }

        public static void setReceiver(PictureBox box)
        {
            itemReceiver = box;
        }

    }
}
