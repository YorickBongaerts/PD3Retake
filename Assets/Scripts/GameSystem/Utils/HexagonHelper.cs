using UnityEngine;

namespace GameSystem.Utils
{
    public class HexagonHelper
    {
        /*
         * https://www.redblobgames.com/grids/hexagons/#conversions
         * function axial_to_cube(hex):
         *      var x = hex.q
         *      var z = hex.r
         *      var y = -x-z
         *      return Cube(x, y, z)
        */
        public static float[] AxialToCube(float q, float r)
        {
            return new float[] { q, -q - r, r };
        }

        /*
        * https://www.redblobgames.com/grids/hexagons/#conversions
        * function cube_to_axial(cube):
        *      var q = cube.x
        *      var r = cube.z
        *      return Hex(q, r)
        */
        public static float[] CubeToAxial(float x, float y, float z)
        {
            return new float[] { x, z };
        }
        /*
         * Converts from hex tile to unity world position
         * 
         * https://www.redblobgames.com/grids/hexagons/#size-and-spacing 
         * In the pointy orientation, a hexagon has width w = sqrt(3) * size and height h = 2 * size. The sqrt(3) comes from sin(60°).
         * The horizontal distance between adjacent hexagon centers is w. The vertical distance between adjacent hexagon centers is h * 3/4.
         * https://www.redblobgames.com/grids/hexagons/#hex-to-pixel-axial
         * function pixel_to_pointy_hex(point):
         * var q = (sqrt(3)/3 * point.x  -  1./3 * point.y) / size
         * var r = (                        2./3 * point.y) / size
         * return hex_round(Hex(q, r))
        */
        public static float[] PointyHexToPixel(float q, float r, float radius)
        {
            float _sqr = Mathf.Sqrt(3f);
            float w = radius * _sqr;
            float h = 2 * radius * .75f;
            float sin60 = _sqr * .5f;
            float[] result = new float[] { radius * (_sqr * q + sin60 * r), h * r };
            return result;
            /*
            
            float[] cube = AxialToCube(radius * (_sqr * q + sin60 * r), h * r);
            float[] rounded = CubeRound(cube[0], cube[1], cube[2]);
            float[] axial = CubeToAxial(rounded[0], rounded[1], rounded[2]);
            return axial;

            */
        }
        /*
         * https://www.redblobgames.com/grids/hexagons/#hex-to-pixel-axial 
         * 
        */
            public static float[] CubeRound(float x, float y, float z)
        {
            float rx = Mathf.Round(x);
            float ry = Mathf.Round(y);
            float rz = Mathf.Round(z);
            float xDiff = Mathf.Abs(rx - x);
            float yDiff = Mathf.Abs(ry - y);
            float zDiff = Mathf.Abs(rz - z);
            if (xDiff > yDiff && xDiff > zDiff)
                rx = -ry - rz;
            else if (yDiff > zDiff)
                ry = -rx - rz;
            else
                rz = -rx - ry;
            return new float[3] { rx, ry, rz };
        }
        /*
         * Converts from unity world position to hex tile
         * 
         * https://www.redblobgames.com/grids/hexagons/#size-and-spacing
         * In the pointy orientation, a hexagon has width w = sqrt(3) * size and height h = 2 * size. The sqrt(3) comes from sin(60°).
         * The horizontal distance between adjacent hexagon centers is w. The vertical distance between adjacent hexagon centers is h * 3/4.
         * https://www.redblobgames.com/grids/hexagons/#hex-to-pixel-axial
         * function pointy_hex_to_pixel(hex):
         * var x = size * (sqrt(3) * hex.q  +  sqrt(3)/2 * hex.r)
         * var y = size * (                         3./2 * hex.r)
         * return Point(x, y)
        */
        public static float[] PixelToPointyHex(float x, float z, float radius)
        {
            float _sqr = Mathf.Sqrt(3f);
            var hex =  new float[] { (_sqr / 3f * x - 0.333333f * z) / radius, 0.666666f * z / radius };
            float[] cube = AxialToCube(hex[0], hex[1]);
            float[] rounded = CubeRound(cube[0], cube[1], cube[2]);
            return rounded;
            //float[] axial = CubeToAxial(rounded[0], rounded[1], rounded[2]);
            //return axial;
        }

        /*
         * Calculates distance between two hex tiles
         * 
         * https://www.redblobgames.com/grids/hexagons/#distances
         * function cube_distance(a, b):
         * return (abs(a.x - b.x) + abs(a.y - b.y) + abs(a.z - b.z)) / 2
        */
        public static float Distance(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            float x = Mathf.Abs(x1 - x2);
            float y = Mathf.Abs(y1 - y2);
            float z = Mathf.Abs(z1 - z2);

            float _result = (x + y + z) / 2;
            return _result;
        }
    }
}
