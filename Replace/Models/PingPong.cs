using System;
using System.IO;
using System.Collections.Generic;

namespace PingPong
{
	public class PingPongCount
	{

		public List<string> ToPingPong(string input)
		{
		int inputCount = int.Parse(input);
		List<string> Output = new List<string>();
		for (int i = 1; i<= inputCount; i++)
			{
				if (i % 15 == 0)
				{
					Output.Add("Pong");
				}
				else if (i % 3 == 0)
				{
					Output.Add("Ping");
				}
				else if (i % 5 == 0 )
				{
					Output.Add("Ping-Pong");
				}
				else
				{
					string num = i.ToString();
					Output.Add(num);
				}
			}			
		return Output;
		}
	}
}










// namespace PingPong
// {
// 	public class PingPongCount
// 	{
// 		public static string ToPingPong(string input)
// 		{

// 			if (int.TryParse(input, out int number)) 
// 			{
// 				int inputCount = int.Parse(input);
// 				for (int i = 	1; i <= inputCount; i++)
// 				{
// 					if (i % 15 == 0)
// 					{
// 						Console.WriteLine("Ping-Pong");
// 						return "Ping-Pong";
// 					}
// 					else if (i % 3 == 0)
// 					{
// 						Console.WriteLine("Ping");
// 						return "Ping";
// 					}
// 					else if (i % 5 == 0 )
// 					{
// 						Console.WriteLine("Pong");
// 						return "Pong";
// 					}
// 					else
// 					{
// 					Console.WriteLine(i);
// 					}
// 				}
// 			} else 
// 			{
// 				Console.WriteLine("Hey! That's not a number!");
// 			}
// 			return input.ToString();
// 		}
// 	}
// }