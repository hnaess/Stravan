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

namespace Stravan
{
    /// <summary>
    /// Encapsulates effort details
    /// </summary>
    public class EffortDetailsV2
    {
        /// <summary>
        /// Gets or sets the effort
        /// </summary>
        public EffortV2 Effort { get; set; }

        /// <summary>
        /// Gets or sets the segment
        /// </summary>
        public SegmentDetailsV2 Segment { get; set; }

        /// <summary>
        /// Gets or sets the leaderboard
        /// </summary>
        public LeaderboardV2 Leaderboard { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendFormat("\nEffort: {0}\n", Effort != null ? Effort.ToString() : string.Empty);
            builder.AppendFormat("Segment: {0}\n", Segment != null ? Segment.ToString() : string.Empty);
            builder.AppendFormat("Leaderboard: {0}\n", Leaderboard != null ? Leaderboard.ToString() : string.Empty);

            return builder.ToString();
        }
    }
}