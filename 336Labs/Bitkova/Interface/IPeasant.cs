﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _336Labs.Bitkova.Interface
{
    interface IPeasant
    {
        void Work();
        public int Health { get; set; }
        void PeasantHealth();
    }
}