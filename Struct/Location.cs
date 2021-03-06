﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJTU.IOTLab.ManTracking.Struct
{
    public class Location
    {
        public double x = 0f;
        public double y = 0f;
        public double z = 0f;
        public double depth = 0f;
        public double offset = 0f;
        public bool isRelative = true;
        public int depthFrameX = -1;
        public int depthFrameY = -1;

        public Location(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.isRelative = false;
        }

        public Location(double depth, double offset)
        {
            this.depth = depth;
            this.offset = offset;
            this.isRelative = true;
        }

        public bool Equals(Location loc)
        {
            if (loc.isRelative != isRelative) return false;
            return isRelative ? 
                depth == loc.depth && offset == loc.offset
                : x == loc.x && y == loc.y && z == loc.z;
        }
    }
}
