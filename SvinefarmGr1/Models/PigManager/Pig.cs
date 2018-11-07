using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SvinefarmGr1.Models.PigManager
{
    public class Pig
    {
        private int pigId;

        public int PigId
        {
            get { return pigId; }
            set { pigId = value; }
        }

        private PigType pigType;

        public PigType PigType
        {
            get { return pigType; }
            set { pigType = value; }
        }

    }
}