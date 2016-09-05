using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion :Item //ID, Name, and NamePlural inherited from Item
    {
        public int AmounttoHeal { get; set; }
    }
}
