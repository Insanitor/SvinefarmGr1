using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SvinefarmGr1.Models.FarmManager;

namespace SvinefarmGr1.Models.PigManager
{
    public class Pig
    {
        #region Fields
        private int pigId;
        private PigType pigType;
        #endregion

        public int PigId
        {
            get { return pigId; }
            set { pigId = value; }
        }

        public int CHRTag { get; set; }

        // Foreign keys
        public PigType PigType
        {
            get { return pigType; }
            set { pigType = value; }
        }
        
        public Box Box { get; set; }
    }
}