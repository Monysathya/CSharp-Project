﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    class Shark : Animal
    {
        public override string Species
        {
            get
            {
                return "Shark";
            }
        }

        public override Class.Type _Class
        {
            get
            {
                return Class.Type.Fish;
            }
        }
    }
}
