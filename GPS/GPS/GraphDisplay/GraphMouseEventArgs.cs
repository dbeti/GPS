using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GPS.Models;
using System.Windows.Forms;

namespace GPS.GraphDisplay
{
    public class GraphMouseEventArgs : MouseEventArgs
    {
        public GraphObject GraphObject;
        public GraphMouseEventArgs(MouseEventArgs args, GraphObject obj)
            : base(args.Button, args.Clicks, args.X, args.Y, args.Delta)
        {
            GraphObject = obj;
        }
    }
}
