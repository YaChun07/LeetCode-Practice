using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreeSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum.Tests
{
    [TestClass()]
    public class threeSumTests
    {
        [TestMethod()]
        public void TwoAnswerTest()
        {
            var threeSumList = new List<List<int>>()
            {

                new List<int>() { -1, -1, 2 },
                new List<int>() { -1, 0, 1 }

            };

            for (int i = 0; i < threeSumList.Count; i++)
            {
                CollectionAssert.AreEqual(threeSumList[i], threeSum.threeSumRef(new int[] { -1, 0, 1, 2, -1, -4 })[i]);
            }
        }
        [TestMethod()]
        public void SingleAnswerTest()
        {
            var threeSumList = new List<List<int>>()
            {
                new List<int>() { -3,0,3 }

            };
            for (int i = 0; i < threeSumList.Count; i++)
            {
                CollectionAssert.AreEqual(threeSumList[i], threeSum.threeSumRef(new int[] { 2, 3, -3, 6, 8, 9, 0 })[i]);

            }
        }
        [TestMethod()]
        public void ZeroAnswerTest()
        {
            var threeSumList = new List<List<int>>()
            {
                new List<int>() { 0, 0, 0 }

            };

            for (int i = 0; i < threeSumList.Count; i++)
            {
                CollectionAssert.AreEqual(threeSumList[i], threeSum.threeSumRef(new int[] { 0, 0, 0, 0, 0, 0 })[i]);
            }
        }
        [TestMethod()]
        public void DuplicateAnswerTest()
        {
            var threeSumList = new List<List<int>>()
            {
                new List<int>() { -1, 0, 1 }

            };

            for (int i = 0; i < threeSumList.Count; i++)
            {
                CollectionAssert.AreEqual(threeSumList[i], threeSum.threeSumRef(new int[] { -1, 0, 1, -1, 0, 1 })[i]);
            }
        }


    }
}