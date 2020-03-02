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
	}
}