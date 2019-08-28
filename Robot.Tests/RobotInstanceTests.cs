using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Robot.Tests
{
    [TestClass]
    public class RobotInstanceTests
    {
        /**
         * Test the robot class with a North attribute and limit on the top
         * */
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Y Value Out of Range")]
        public void TestNorth()
        {
            RobotInstance rob = new RobotInstance("NORTH",4,3);
            Assert.AreEqual("4,3,NORTH", rob.ToString(), "Object created has wrong attributes.");
            rob.Move();
            Assert.AreEqual("4,4,NORTH", rob.ToString(), "Movement from not working");
            rob.Move();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Y Value Out of Range")]
        public void TestSouth()
        {
            RobotInstance rob = new RobotInstance("SOUTH", 2, 1);
            Assert.AreEqual("2,1,SOUTH", rob.ToString(), "Object created has wrong attributes.");
            rob.Move();
            Assert.AreEqual("2,0,SOUTH", rob.ToString(), "Movement from not working");
            rob.Move();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "X Value Out of Range")]
        public void TestEast()
        {
            RobotInstance rob = new RobotInstance("EAST", 3, 3);
            Assert.AreEqual("3,3,EAST", rob.ToString(), "Object created has wrong attributes.");
            rob.Move();
            Assert.AreEqual("4,3,EAST", rob.ToString(), "Movement from not working");
            rob.Move();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "X Value Out of Range")]
        public void TestWest()
        {
            RobotInstance rob = new RobotInstance("WEST", 1, 3);
            Assert.AreEqual("1,3,WEST", rob.ToString(), "Object created has wrong attributes.");
            rob.Move();
            Assert.AreEqual("0,3,WEST", rob.ToString(), "Movement from not working");
            rob.Move();
        }


    }
}
