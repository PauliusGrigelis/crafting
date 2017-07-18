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
        Form parentForm;


        public Inventory(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            // Iventory fill for debug purposes:
            item1.ImageLocation = @"./item_icons/boots.png";
            item1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void item1_DoubleClick(object sender, EventArgs e)
        {

            this.parentForm.Controls[]
        }
    }
}
