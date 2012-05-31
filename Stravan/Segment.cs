﻿#region MIT License

/*
 * Copyright (c) 2012 Kristopher Baker (kris@empyrealnight.com)
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

#endregion

using System.Text;
using EmpyrealNight.Core.Json;

namespace Stravan
{
    /// <summary>
    /// Encapsulates a segment in the Strava API
    /// </summary>
    public class Segment : IEntity
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        [JsonName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [JsonName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the climb category
        /// </summary>
        [JsonName("climbCategory")]
        public string ClimbCategory { get; set; }

        /// <summary>
        /// Gets or sets the elevation gain
        /// </summary>
        [JsonName("elevationGain")]
        public double ElevationGain { get; set; }

        /// <summary>
        /// Gets or sets the elevation high
        /// </summary>
        [JsonName("elevationHigh")]
        public double ElevationHigh { get; set; }

        /// <summary>
        /// Gets or sets the elevation low
        /// </summary>
        [JsonName("elevationLow")]
        public double ElevationLow { get; set; }

        /// <summary>
        /// Gets or sets the distance
        /// </summary>
        [JsonName("distance")]
        public double Distance { get; set; }

        /// <summary>
        /// Gets or sets the average grade
        /// </summary>
        [JsonName("averageGrade")]
        public double AverageGrade { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendFormat("\nid: {0}\n", Id);
            builder.AppendFormat("name: {0}\n", Name ?? string.Empty);
            builder.AppendFormat("climbCategory: {0}\n", ClimbCategory ?? string.Empty);
            builder.AppendFormat("elevationGain: {0}\n", ElevationGain);
            builder.AppendFormat("elevationHigh: {0}\n", ElevationHigh);
            builder.AppendFormat("elevationLow: {0}\n", ElevationLow);
            builder.AppendFormat("distance: {0}\n", Distance);
            builder.AppendFormat("averageGrade: {0}\n", AverageGrade);

            return builder.ToString();
        }
    }
}