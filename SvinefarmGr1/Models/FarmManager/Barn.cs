using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SvinefarmGr1.Models.FarmManager
{
    public class Barn
    {
        private int barnId;

        public int BarnId
        {
            get { return barnId; }
            set { barnId = value; }
        }

        private string barnName;

        public string BarnName
        {
            get { return barnName; }
            set { barnName = value; }
        }


    }
}