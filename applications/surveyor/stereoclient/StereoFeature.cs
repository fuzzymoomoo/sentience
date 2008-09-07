/*
    single stereo feature
    Copyright (C) 2008 Bob Mottram
    fuzzgun@gmail.com

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace surveyor.vision
{
    /// <summary>
    /// stores a single stereo feature
    /// </summary>
    public class StereoFeature
    {
        public float x, y;
        public float disparity;
		public byte[] colour;
        
        public StereoFeature(float x, float y, float disparity)
        {
            this.x = x;
            this.y = y;
            this.disparity = disparity;
        }

        public void SetColour(byte r, byte g, byte b)
        {
            colour = new byte[3];
            colour[0] = r;
            colour[1] = g;
            colour[2] = b;
        }
    }
}
