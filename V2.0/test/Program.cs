using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mailinblue;

namespace test
{
class Program
	{
		public static void Main(string[] args)
		{
			var test = new SendinBlueApi("<access key>");
            Dictionary<string, int> data = new Dictionary<string, int>();
            data.Add("page", 1);
            data.Add("page_limit", 3);
            var getProcesses = test.GetProcesses(data);
            Console.WriteLine(getProcesses);
			Console.ReadKey(true);
		}
	}
}