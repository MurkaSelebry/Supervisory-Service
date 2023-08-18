using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervisoryServiceLibrary
{
    internal class BuildingFilter : IFilter
    {
        public float MinSquare { get; set; } = 0f;
        public float MaxSquare { get; set; } = float.MaxValue;
        public DateTime MinDate { get; set; } = DateTime.MinValue;
        public DateTime MaxDate { get; set; } = DateTime.MaxValue;
        public string Material { get; set; } = string.Empty;
        public int MinFloors { get; set; } = 0;
        public int MaxFloors { get; set; } = int.MaxValue;
        public BuildingFilter() { }
        public BuildingFilter(float minSquare, float maxSquare, DateTime minDate, DateTime maxDate, string material, int minFloors, int maxFloors)
        {
            MinSquare = minSquare;
            MaxSquare = maxSquare;
            MinDate = minDate;
            MaxDate = maxDate;
            Material = material;
            MinFloors = minFloors;
            MaxFloors = maxFloors;
        }
        public object[] Find(object[] items)
        {
            List<Building> results = new List<Building>();
            foreach (var item in items)
            {
                if (item is Building)
                {
                    var b = (Building)item;
                    if (!string.IsNullOrEmpty(Material))
                    {
                        if ((Enumerable.Range(MinFloors, MaxFloors).Contains(b.Floors)) && (MinSquare <= b.Square && b.Square <= MaxSquare) && (MinDate <= b.Date && b.Date <= MaxDate) && (b.Material.Equals(Material)))
                        {
                            results.Add(b);
                        }
                    }
                    else
                    {
                        if ((Enumerable.Range(MinFloors, MaxFloors).Contains(b.Floors)) && (MinSquare <= b.Square && b.Square <= MaxSquare) && (MinDate <= b.Date && b.Date <= MaxDate))
                            results.Add(b);
                    }
                }
            }
            return results.ToArray();
        }
    }
}
