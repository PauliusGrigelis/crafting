using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace crafting.Models
{
    public class Craft
    {
        [Key]
        public int Id { get; set; }
        public Item item { get; set; }
        public IList<Item> components { get; set; }
    }
}
