using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.GraphDisplay
{
    class SimpleCoordinateConverter : ICoordinateConverter
    {
        public Point ToDbCoord(Point displayCoord)
        {
            return displayCoord - new Size(100, 100);
        }

        public Point ToDisplayCoord(Point dbCoord)
        {
            return dbCoord + new Size(100, 100);
        }
    }
}
