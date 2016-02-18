using DIBRIS.Hippie;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GPS.PathFinders
{
    struct State : IEquatable<State>
    {
        public Models.Node Node;
        public ulong FeatureMask;
        
        public State(Models.Node node, IDictionary<int, int> featureMap)
        {
            var cnt = featureMap.Count;
            ALL_VISITED_MASK = cnt == 0 ? 0ul : (1ul << cnt) - 1;
            Node = node;
            FeatureMask = 0ul;
            this.featureMap = featureMap;
            updateFeatureMask(node);
        }

        public State(State lastState, Models.Arc arc, Models.Node node)
        {
            ALL_VISITED_MASK = lastState.ALL_VISITED_MASK;
            Node = node;
            FeatureMask = lastState.FeatureMask;
            featureMap = lastState.featureMap;
            updateFeatureMask(node);
            updateFeatureMask(arc);
        }

        public IEnumerable<Tuple<State, PathData>> Neighborhood
        {
            get
            {
                var state = this;
                var outArcs = Enumerable.Empty<Tuple<State, PathData>>();
                var inArcs = Enumerable.Empty<Tuple<State, PathData>>();
                if (Node.OutArcs != null)
                {
                    outArcs = from arc in Node.OutArcs
                        select Tuple.Create(
                            new State(state, arc, arc.EndNode),
                            new PathData(arc.Length, state, arc));
                }
                if (Node.InArcs != null)
                {
                    inArcs = from arc in Node.InArcs
                        where !arc.Directed
                        select Tuple.Create(
                            new State(state, arc, arc.StartNode),
                            new PathData(arc.Length, state, arc));
                }
                return outArcs.Concat(inArcs);
            }
        }

        public bool AllFeaturesVisited()
        {
            return FeatureMask == ALL_VISITED_MASK;
        }

        public bool Equals(State other)
        {
            return Node == other.Node && FeatureMask == other.FeatureMask;
        }
        
        public override bool Equals(object obj)
        {
            return Equals((State)obj);
        }

        public override int GetHashCode()
        {
            return new Tuple<int, ulong>(
                Node.GraphObjectId, FeatureMask).GetHashCode();
        }

        private IDictionary<int, int> featureMap;
        private readonly ulong ALL_VISITED_MASK;

        private void updateFeatureMask(Models.GraphObject graphObject)
        {
            if (graphObject.Features == null) return;
            foreach(var feature in graphObject.Features)
            {
                int ftid = feature.FeatureTypeId;
                if (featureMap.ContainsKey(ftid))
                {
                    FeatureMask |= 1ul << featureMap[ftid];
                }
            }
        }
    }

    struct PathData
    {
        public double Length;
        public State? FromState;
        public Models.Arc UsingArc;
        public IHeapHandle<State, double> QueueHandle;

        public PathData(
            double length = 0,
            State? fromState = null,
            Models.Arc usingArc = null,
            IHeapHandle<State, double> queueHandle = null)
        {
            Length = length;
            FromState = fromState;
            UsingArc = usingArc;
            QueueHandle = queueHandle;
        }
    }

}