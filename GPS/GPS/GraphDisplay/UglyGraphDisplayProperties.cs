﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.GraphDisplay
{
    class UglyGraphDisplayProperties : IGraphDisplayProperties
    {
        public int NodeRadius
        {
            get { return Properties.Settings.Default.Diameter; }
        }
        readonly Font labelFont = new Font("Arial", 8);
        public Font LabelFont { get { return labelFont; } }
        public Brush LabelBrush { get { return Brushes.Black; } }
        public Brush NodeBrush { get { return Brushes.Blue; } }
        public Pen ArcPen { get { return Pens.Blue; } }
        public Color Background
        {
            get { return SystemColors.ControlLightLight; }
        }
        public Pen SelectedPen { get { return Pens.Red; } }
    }
}
