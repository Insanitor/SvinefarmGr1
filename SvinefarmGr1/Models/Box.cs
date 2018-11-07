using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SvinefarmGr1.Models
{
    public class Box
    {
        private int boxId;

        public int BoxId
        {
            get { return boxId; }
            set { boxId = value; }
        }
        private string boxName;

        public string BoxName
        {
            get { return boxName; }
            set { boxName = value; }
        }



    }
}