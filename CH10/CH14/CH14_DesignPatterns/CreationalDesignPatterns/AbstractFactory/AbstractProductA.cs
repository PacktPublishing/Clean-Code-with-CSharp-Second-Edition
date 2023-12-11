﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH14_DesignPatterns.CreationalDesignPatterns.AbstractFactory
{
    public abstract class AbstractProductA
    {
        public abstract void Operation(AbstractProductB productB);
    }
}
