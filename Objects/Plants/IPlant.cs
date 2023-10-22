using BillSystem.Objects.Things;
using Microsoft.Xna.Framework;
using System;

namespace BillSystem.Objects.Plants
{
    public interface IPlant : IThing, ISaveable
    {
        string Name { get; }
        Color Color { get; }
    }
}
