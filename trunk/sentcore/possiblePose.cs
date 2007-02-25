/*
    Sentience 3D Perception System
    Copyright (C) 2000-2007 Bob Mottram
    fuzzgun@gmail.com

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace sentience.core
{
    public class possiblePose
    {
        public int index;
        public float x, y;
        public float pan;     //bucketed pan value
        public float score;

        public possiblePose(int index, float x, float y, int pan, float score)
        {
            this.index = index;
            this.x = x;
            this.y = y;
            this.pan = pan;
            this.score = score;
        }

        public possiblePose(float x, float y, int pan)
        {
            this.x = x;
            this.y = y;
            this.pan = pan;
            this.score = 1;
        }
    }
}
