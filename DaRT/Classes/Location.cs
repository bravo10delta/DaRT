﻿using System;
using System.Drawing;

namespace DaRT
{
    public class Location
    {
        public String location = "";
        public Image flag = null;

        public Location(String location, Image flag)
        {
            this.location = location;
            this.flag = flag;
        }
    }
}
