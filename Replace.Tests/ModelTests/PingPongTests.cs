using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;
using System;
using System.IO;

namespace PingPong.Tests 
{
	[TestClass]
	public class PingPongTests
	{
		[TestMethod]
		public void ToPingPong_InputNan_True()
		{
			PingPongCount testPingPong = new PingPongCount();
			Assert.AreEqual(false, testPingPong.ToPingPong("K"));
		}
		[TestMethod]
		public void ToPingPong_ReturnRangeFromInput_True()
		{
			PingPongCount testPingPong = new PingPongCount();
			Assert.AreEqual(true, testPingPong.ToPingPong("6"));
		}
		[TestMethod]
		public void ToPingPong_ReplaceNumbersDivisibleByThree_True()
		{
			PingPongCount testPingPong = new PingPongCount();
			Assert.AreEqual("Ping", testPingPong.ToPingPong("6"));
		}
		[TestMethod]
		public void ToPingPong_ReplaceNumbersDivisibleByFive_True()
		{
			PingPongCount testPingPong = new PingPongCount();
			Assert.AreEqual("Pong", testPingPong.ToPingPong("10"));
		}
		[TestMethod]
		public void ToPingPong_ReplaceNumbersDivisibleByThreeAndFive_True()
		{
			PingPongCount testPingPong = new PingPongCount();
			Assert.AreEqual("Ping-Pong", testPingPong.ToPingPong("15"));
		}
	}
}