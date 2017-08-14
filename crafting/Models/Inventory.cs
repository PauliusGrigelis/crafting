using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace crafting.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        public IList<Item> items { get; set; }
    }
}
