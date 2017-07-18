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
        public craftingMenu()
        {
            InitializeComponent();
            this.Location = new Point(100, 100);
            Form inventoryForm = new Inventory(this);
            inventoryForm.Show();
            inventoryForm.Location = new Point(200 + this.Width, this.Location.Y);
        }

        private void craftButton_Click(object sender, EventArgs e)
        {

        }

        public string getFreeSlot()
        {
            //Note: find 1st free slot
            return this.item1.Name;
        }
    }
}
