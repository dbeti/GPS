﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.GraphDisplay
{
    interface IGraphDisplayProperties
    {
        int NodeRadius { get; }
        int ArcArrowSize { get; }
        Font LabelFont { get; }
        Brush LabelBrush { get; }
        Brush NodeBrush { get; }
        Pen ArcPen { get; }
        Color Background { get; }
        Pen SelectedPen { get; }
        Pen PathPen { get; }
        Pen HighlightPen { get; }
    }
}
