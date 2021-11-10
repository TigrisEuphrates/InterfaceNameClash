﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    interface IDrawToForm
    {
        void Draw();
    }
    interface IDrawToMemory
    {
        void Draw();
    }
    interface IDrawToPrinter
    {
        void Draw();
    }
}
