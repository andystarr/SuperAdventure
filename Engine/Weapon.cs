﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item //ID &  Name 
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
    }
}
