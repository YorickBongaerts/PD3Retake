using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Utils
{
    public class Direction
    {
        public enum HexCardinal
        {
            //North,
            NorthEast,
            East,
            SouthEast,
            //South,
            SouthWest,
            West,
            NorthWest
        }
        public enum Cardinal
        {
            North,
            East,
            South,
            West
        }
        public enum Ordinal
        {
            NorthEast,
            SouthEast,
            SouthWest,
            NorthWest
        }
    }
}
