﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models {
    public abstract class Person {
        public int Id {
            get; set;
        }
        public string FirstName {
            get; set;
        }
        public string LastName {
            get; set;
        }
        public override string ToString() {
            return FirstName + " " + LastName;
        }
    } // public abstract class Person
}
