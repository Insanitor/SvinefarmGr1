using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SvinefarmGr1.Models.FarmManager;

namespace SvinefarmGr1.Models.SensorManager
{
    public class TemperatureSensor : Sensor, IBarnSensor
    {
        public Barn Barn { get; set; }
    }
}