﻿using System;
using SharpDX;

namespace Coman3.API.Extentions
{
    /// <summary>
    /// A user friendly, easy to use random class that allows generation of vectors and supports ranges.
    /// </summary>
    public static class Random
    {
         public static System.Random SRandom { get; private set; }

        static Random()
        {
            SRandom = new System.Random(Guid.NewGuid().GetHashCode());
        }

        public static float NextFloat(float min, float max)
        {
            return SRandom.NextFloat(min, max);
        }
        public static int Next(int min, int max)
        {
            return SRandom.Next(min, max);
        }
        public static Vector3 RandomVector3(Vector3 min, Vector3 max)
        {
            return SRandom.NextVector3(min, max);
        }
        public static double NextDouble(double min, double max)
        {
            return SRandom.NextDouble(min, max);
        }

        /// <summary>
        /// Returns a value in which is within the range of the specified value.
        /// 
        /// <example>
        /// Value = 10
        /// Range = 2
        /// Returns a random number between 8 to 12
        /// </example>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static int NextRange(this int value, int range)
        {
            return Next(value - range, value + range);
        }
        /// <summary>
        /// Returns a value in which is within the range of the specified value.
        /// 
        /// <example>
        /// Value = 10
        /// Range = 2
        /// Returns a random number between 8 to 12
        /// </example>
        /// 
        /// </summary>
        public static float NextFloatRange(this float value, float range)
        {
            return NextFloat(value - range, value + range);
        }
        /// <summary>
        /// Returns a value in which is within the range of the specified value.
        /// 
        /// <example>
        /// Value = 10
        /// Range = 2
        /// Returns a random number between 8 to 12
        /// </example>
        /// 
        /// </summary>
        public static double NextDoubleRange(this double value, double range)
        {
            return NextDouble(value - range, value + range);
        }
    }
}