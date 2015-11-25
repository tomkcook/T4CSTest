using System;
using T4CSTest;

namespace Templates
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string code = "using System; namespace Foo { public class Program { public static void Main(string[] args) { Console.WriteLine(\"Hello, World\"); } } }";
			Utilities u = new Utilities();
			string ns = u.GetFirstNamespace(code);
			Console.WriteLine (ns);
		}
	}
}

