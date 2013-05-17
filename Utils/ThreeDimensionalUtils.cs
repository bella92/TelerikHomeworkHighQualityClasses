﻿using System;

namespace Utils
{
    public class ThreeDimensionalUtils
    {
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
            return distance;
        }

        public static double CalcDiagonal(double width, double height, double depth)
        {
            double diagonal = Math.Sqrt((width * width) + (height * height) + (depth * depth));
            return diagonal;
        }

        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }
    }
}