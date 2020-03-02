using System;
using System.IO;

namespace PingPong
{
	public class PingPongCount
	{
		public bool ToPingPong(string input)
		{
			int number;
			return TryParse(input, out number);
		}
	}
}