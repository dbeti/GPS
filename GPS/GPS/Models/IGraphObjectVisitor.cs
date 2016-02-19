using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Models
{
    public interface IGraphObjectVisitor
    {
        void VisitGraphObject(GraphObject graphObject);
        void VisitNode(Node node);
        void VisitArc(Arc arc);
    }
}
