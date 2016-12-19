using Microsoft.VisualStudio.TestTools.UnitTesting;
using FriendOrFoe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace FriendOrFoe.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void FriendOrFoeTest1()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
        }
        [TestMethod()]
        public void FriendOrFoeTest2()
        {
            string[] expected = { "", "Mark" };
            string[] names = { "Ryan", "", "Mark", "Jimmy" };
            CollectionAssert.AreNotEqual(expected, Kata.FriendOrFoe(names));
        }
        [TestMethod()]
        public void FriendOrFoeTest3()
        {
            string[] expected = { "" };
            string[] names = { "Ryan", "", "Mark", "Jimmy" };
            CollectionAssert.AreNotEqual(expected, Kata.FriendOrFoe(names));
        }
        [TestMethod()]
        public void FriendOrFoeTest4()
        {
            string[] expected = { "" };
            string[] names = { "Ryan", "Mark", "Jimmy" };
            CollectionAssert.AreNotEqual(expected, Kata.FriendOrFoe(names));
        }
        [TestMethod()]
        public void FriendOrFoeTest5()
        {
            string[] expected = {};
            string[] names = { "Ryan", "Mark", "Jimmy" };
            CollectionAssert.AreNotEqual(expected, Kata.FriendOrFoe(names));
        }
        [TestMethod()]
        public void FriendOrFoeTest6()
        {
            string[] expected = { "Ryan" };
            string[] names = { };
            CollectionAssert.AreNotEqual(expected, Kata.FriendOrFoe(names));
        }
    }
}