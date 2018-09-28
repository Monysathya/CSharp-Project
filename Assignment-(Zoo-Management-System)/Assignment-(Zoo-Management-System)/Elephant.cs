﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    class Elephant : Animal
    {
        public override bool canFly
        {
            get
            {
                return false;
            }
        }

        public override bool isDangerous
        {
            get
            {
                return false;
            }
        }

        public override string Species
        {
            get
            {
                return "Elephant";
            }
        }

        public override string _Class
        {
            get
            {
                return Class.ClassType.Mammal.ToString();
            }
        }
    }
}
