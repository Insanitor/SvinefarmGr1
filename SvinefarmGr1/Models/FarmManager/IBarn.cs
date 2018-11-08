using System.Collections.Generic;

namespace SvinefarmGr1.Models.FarmManager
{
    public interface IBarn
    {
        int BarnId { get; set; }
        string BarnName { get; set; }
        ICollection<Box> Boxes { get; set; }
        Farm Farm { get; set; }
    }
}