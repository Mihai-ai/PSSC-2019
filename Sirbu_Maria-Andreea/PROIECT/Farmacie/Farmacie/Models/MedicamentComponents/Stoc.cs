﻿using Farmacie.Models.CommonComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacie.Models.MedicamentComponents
{
    public class Stoc
    {
        private Number stoc;

        public Stoc(Number st)
        {

            stoc = st;
        }
        public Number getStoc { get { return stoc; } }
    }
}
