using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.PathFinders
{
    interface IPathFinder
    {
        IList<Models.GraphObject> FindPath(
            Models.Node start,
            Models.Node end,
            IEnumerable<Models.FeatureType> pathFeatures);
    }
}
