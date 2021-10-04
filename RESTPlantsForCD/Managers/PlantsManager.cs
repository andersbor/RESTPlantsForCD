using System.Collections.Generic;
using RESTPlantsForCD.Models;

namespace RESTPlantsForCD.Managers
{
    public class PlantsManager
    {
        private static int _nextId = 1;
        private static readonly List<Plant> Data = new List<Plant>
        {
            new Plant {Id = _nextId++, Name="Sunflower"},
            new Plant {Id = _nextId++, Name="Palm tree"}
        };

        public List<Plant> GetAll()
        {
            return Data;
        }


    }
}
