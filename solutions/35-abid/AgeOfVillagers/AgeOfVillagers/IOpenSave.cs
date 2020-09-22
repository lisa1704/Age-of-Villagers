﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public interface IOpenSave
    {
        void execute();
    }

    public struct VillageState
    {
        public string Vname;
        //public int NationIndex;
        //public Color TerrainColor;
        public List<Point> HPoint;
        public List<Point> TPoint;
        public List<Point> WPoint;
    }
}