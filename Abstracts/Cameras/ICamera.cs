using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSystem.Abstracts.Cameras
{
    public interface ICamera
    {
        public uint LocationX { get; set; }
        public uint LocationY { get; set; }
        public uint PixelPerTile { get; set; }
    }
}
