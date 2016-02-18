using System;
using System.Collections.Generic;

using DIBRIS.Hippie;


namespace GPS.PathFinders
{
    class AStarPathFinder : IPathFinder
    {
        public IList<Models.GraphObject> FindPath(
            Models.Node start,
            Models.Node end,
            IEnumerable<Models.FeatureType> pathFeatures)
        {
            initializeData(start, pathFeatures);
            while (queue.Count != 0)
            {
                var heapHandle = queue.RemoveMin();
                State currentState = heapHandle.Value;
                double distance = heapHandle.Priority;
                done.Add(currentState);

                if (currentState.AllFeaturesVisited() &&
                    currentState.Node == end)
                {
                    return generatePath(currentState);
                }

                foreach (var next in currentState.Neighborhood)
                {
                    State state = next.Item1;
                    PathData pathData = next.Item2;
                    if (!done.Contains(state))
                    {
                        pathData.Length += distance;
                        updateState(state, pathData);
                    }
                }
            }
            return null;
        }

        private const byte HEAP_CHILDREN = 5;
        
        private ArrayHeap<State, double> queue;
        private Dictionary<State, PathData> discovered;
        private HashSet<State> done;
        private Dictionary<int, int> featureMap;
 
        private void initializeData(
            Models.Node start, 
            IEnumerable<Models.FeatureType> pathFeatures)
        {
            createFeatureMap(pathFeatures);
            queue = HeapFactory.NewRawArrayHeap<State, double>(HEAP_CHILDREN);
            discovered = new Dictionary<State, PathData>();
            done = new HashSet<State>();
            updateState(new State(start, featureMap));
        }

        private void createFeatureMap(
            IEnumerable<Models.FeatureType> features)
        {
            featureMap = new Dictionary<int, int>();
            int idx = 0;
            foreach (var feature in features)
            {
                featureMap[feature.Id] = idx++;
            }
        }

        private void updateState(
            State state,
            PathData pathData = new PathData())
        {
            if (discovered.ContainsKey(state))
            {
                pathData.QueueHandle = discovered[state].QueueHandle;
                if (pathData.Length < pathData.QueueHandle.Priority)
                {
                    queue.UpdatePriorityOf(
                        pathData.QueueHandle, pathData.Length);
                    discovered[state] = pathData;
                }
            }
            else
            {
                pathData.QueueHandle = queue.Add(state, pathData.Length);
                discovered[state] = pathData;
            }
        }

        private IList<Models.GraphObject> generatePath(State endState)
        {
            var path = new List<Models.GraphObject>();
            State? lastState = endState;
            while (true)
            {
                path.Add(lastState.Value.Node);
                var pathData = discovered[lastState.Value];
                lastState = pathData.FromState;
                if (!lastState.HasValue) break;
                path.Add(pathData.UsingArc);
            }
            path.Reverse();
            return path;
        }
    }
}
