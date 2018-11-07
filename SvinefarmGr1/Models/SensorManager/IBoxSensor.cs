using SvinefarmGr1.Models.FarmManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvinefarmGr1.Models.SensorManager
{
    public interface IBoxSensor
    {
        Box Box { get; set; }
    }
}
