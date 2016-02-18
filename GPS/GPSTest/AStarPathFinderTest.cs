using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using GPS;
using GPS.Models;
using GPS.PathFinders;
using Moq;
using System.Data.Entity;
using Effort;
using Effort.DataLoaders;
using System.Data.Entity.Migrations;

namespace GPSTests
{

    [TestClass]
    public class AStarPathFinderTest
    {

        Node[] nodes;
        Arc[] arcs;
        FeatureType[] ftypes;
        Feature[] features;

        [TestMethod]
        public void SimpleShortestPath()
        {
            createContext();

            var start = nodes[0];
            var end = nodes[3];
            var features = new FeatureType[0];
            var shortestPath = new List<GraphObject>()
            {
                nodes[0],
                arcs[1],
                nodes[2],
                arcs[5],
                nodes[3]
            };

            var pathFinder = new AStarPathFinder();

            var path = pathFinder.FindPath(start, end, new List<FeatureType>());

            assertPathsEqual(shortestPath, path);
        }

        [TestMethod]
        public void ShortestPathWithFeature()
        {
            createContext();

            var start = nodes[0];
            var end = nodes[3];
            var features = new FeatureType[]
            {
                ftypes[1]
            };
            var shortestPath = new List<GraphObject>()
            {
                nodes[0],
                arcs[0],
                nodes[1],
                arcs[6],
                nodes[5],
                arcs[7],
                nodes[3]
            };

            var pathFinder = new AStarPathFinder();
    
            var path = pathFinder.FindPath(start, end, features);
    
            assertPathsEqual(shortestPath, path);
        }

        [TestMethod]
        public void ShortestPathWithUndirectedArc()
        {
            createContext();

            var start = nodes[0];
            var end = nodes[3];
            var features = new FeatureType[]
            {
                ftypes[1],
                ftypes[0]
            };
            var shortestPath = new List<GraphObject>()
            {
                nodes[0],
                arcs[2],
                nodes[4],
                arcs[2],
                nodes[0],
                arcs[0],
                nodes[1],
                arcs[6],
                nodes[5],
                arcs[7],
                nodes[3]
            };

            var pathFinder = new AStarPathFinder();

            var path = pathFinder.FindPath(start, end, features);
            
            assertPathsEqual(shortestPath, path);
        }

        private void assertPathsEqual(
            ICollection<GraphObject> expected,
            ICollection<GraphObject> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count, "length missmatch");
            Assert.IsTrue(expected
                .Zip(actual, (a, b) => a.GraphObjectId == b.GraphObjectId)
                .All(x => x), "value missmatch");
        }

        private GPSContext createContext()
        {
            var connection = DbConnectionFactory.CreateTransient();
            var db = new GPSContext(connection);
            db.Database.CreateIfNotExists();

            nodes = new Node[]
            {
                new Node("Left Up",    100, 100),
                new Node("Right Up",   200, 100),
                new Node("Left Down",  100, 200),
                new Node("Right Down", 200, 200),
                new Node("Center",     150, 150),
                new Node("Around we go", 300, 150),
            };

            arcs = new Arc[]
            {
                new Arc("LU-RU", nodes[0], nodes[1]),
                new Arc("LU-LD", nodes[0], nodes[2]),
                new Arc("LU-C", nodes[0], nodes[4], false),
                new Arc("RD-C", nodes[3], nodes[4]),
                new Arc("RD-RU", nodes[3], nodes[1]),
                new Arc("LD-RD", nodes[2], nodes[3]),
                new Arc("RG1", nodes[1], nodes[5]),
                new Arc("RG2", nodes[5], nodes[3])
            };

            ftypes = new FeatureType[]
            {
                new FeatureType("Store"),
                new FeatureType("Diner")
            };

            features = new Feature[]
            {
                new Feature("Wallmart", nodes[4], ftypes[0]),
                new Feature("Mo's", nodes[5], ftypes[1])
            };

            db.Nodes.AddOrUpdate(nodes);
            db.Arcs.AddOrUpdate(arcs);
            db.FeatureTypes.AddOrUpdate(ftypes);
            db.Features.AddOrUpdate(features);

            db.SaveChanges();

            return db;
        }
    }
}
