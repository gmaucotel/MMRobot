using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Robot.Tests
{
    [TestClass]
    public class DirectionTests
    {
        /**
         * Test the direction class with a North attribute 
         * */
        [TestMethod]
        public void TestNorthCreationAndRotations()
        {
            Direction dir = new Direction("NORTH");
            Assert.AreEqual(dir.ToString(), "NORTH", "Object created has wrong attributes.");
            dir.Rotate("LEFT");
            Assert.AreEqual(dir.ToString(), "WEST", "Left rotation from north is not working.");
            dir = new Direction("NORTH");
            dir.Rotate("RIGHT");
            Assert.AreEqual(dir.ToString(), "EAST", "Right rotation from north is not working.");
        }

        [TestMethod]
        public void TestSouthCreationAndRotations()
        {
            Direction dir = new Direction("SOUTH");
            Assert.AreEqual(dir.ToString(), "SOUTH", "Object created has wrong attributes.");
            dir.Rotate("LEFT");
            Assert.AreEqual(dir.ToString(), "EAST", "Left rotation from south is not working.");
            dir = new Direction("SOUTH");
            dir.Rotate("RIGHT");
            Assert.AreEqual(dir.ToString(), "WEST", "Right rotation from south is not working.");
        }

        [TestMethod]
        public void TestEastCreationAndRotations()
        {
            Direction dir = new Direction("EAST");
            Assert.AreEqual(dir.ToString(), "EAST", "Object created has wrong attributes.");
            dir.Rotate("LEFT");
            Assert.AreEqual(dir.ToString(), "NORTH", "Left rotation from east is not working.");
            dir = new Direction("EAST");
            dir.Rotate("RIGHT");
            Assert.AreEqual(dir.ToString(), "SOUTH", "Right rotation from east is not working.");
        }

        [TestMethod]
        public void TestWestCreationAndRotations()
        {
            Direction dir = new Direction("WEST");
            Assert.AreEqual(dir.ToString(), "WEST", "Object created has wrong attributes.");
            dir.Rotate("LEFT");
            Assert.AreEqual(dir.ToString(), "SOUTH", "Left rotation from west is not working.");
            dir = new Direction("WEST");
            dir.Rotate("RIGHT");
            Assert.AreEqual(dir.ToString(), "NORTH", "Right rotation from west is not working.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid direction")]
        public void TestCreationException()
        {
            Direction dir = new Direction("FOO");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid rotation")]
        public void TestRotationException()
        {
            Direction dir = new Direction("NORTH");
            dir.Rotate("FOO");
        }
    }
}
