﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjectionStarter.Library
{
    public class Vocal: IInstrument 
    {
        public string Play()
        {
            return "Traaa laaa laaa la la";
        }
    }
}
