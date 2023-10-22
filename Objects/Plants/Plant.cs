using Microsoft.Xna.Framework;
using System;

namespace BillSystem.Objects.Plants
{
    public class Plant : IPlant
    {
        public Guid Id { get; }

        public string Name { get; protected set; }

        public Color Color { get; protected set; }

        public Plant()
        {
            Id = Guid.NewGuid();
        }

        public string ExposeData()
        {
            return $"{Name}|||{Id}";
        }
    }
}
