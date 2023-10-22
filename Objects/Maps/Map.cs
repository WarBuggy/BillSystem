using BillSystem.Abstracts.Locations;
using BillSystem.Objects.Plants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BillSystem.Objects.Maps
{
    public class Map
    {
        public int Width { get; }
        public int Height { get; }
        public Dictionary<Location, IPlant> Plants { get; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            Plants = new();

            List<Type> allowedPlantTypes = new() { typeof(Pine) };
            GenerateTrees(allowedPlantTypes);
        }

        private void GenerateTrees(List<Type> allowedPlantTypes)
        {
            for (int i = 0; i < 100; i++)
            {
                var x = RandomNumberGenerator.GetInt32(Width);
                var y = RandomNumberGenerator.GetInt32(Height);
                Location loc = new(x, y);
                if (Plants.ContainsKey(loc))
                {
                    continue;
                }

                var plantTypeIndex = RandomNumberGenerator.GetInt32(allowedPlantTypes.Count);
                var plantType = allowedPlantTypes[plantTypeIndex];

            }
        }
    }
}
