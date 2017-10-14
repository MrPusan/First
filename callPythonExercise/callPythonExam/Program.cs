using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace callPythonExample
{
	class Program
	{
		static void Main(string[] args)
		{
			string getAppPath = System.IO.Directory.GetCurrentDirectory();
			int index1;
			index1 = getAppPath.IndexOf("callPythonExam");
			int pathLength = getAppPath.Length;
			string Lpath;
			if (index1 > 0)
			{
				Lpath = getAppPath.Remove(index1, pathLength - index1);
			}
			else
			{
				Lpath = getAppPath;
			}
			string filePath = Lpath + "calc\\calc.py";

			var engine = Python.CreateEngine();

			/*
			 * The dynamic keyword is needed here because Python is an interpreted scripting language where calls are bound at run time, not at compile time.
			 * There is no simple or practical way to bind calls to Python at compile time because Python is designed to be a dynamic language which is resolved at runtime.
			 * Since C# is a strongly typed language it expects to resolve calls at compile time with strict type checking.
			 * In short, C# binds statically at compile time, Python dynamically at runtime. 
			 * Something has to give, and the only valid solution was for C# to allow runtime binding for method calls.
			 * 
			 * reference : 'https://blogs.msdn.microsoft.com/charlie/2009/10/25/running-ironpython-scripts-from-a-c-4-0-program/'
			 */
			dynamic py = engine.ExecuteFile(filePath);  //call python with dynamic keyword
			dynamic calc = py.Calculator(); 			//class calculator

			Console.WriteLine(calc.__class__.__name__);
			//write class name, 'calulation'

			double a = 7.5;
			double b = 2.5;
			double result;

			// call function 'add' of class 'Calulator' in calc.py
			result = calc.add(a, b);
			Console.WriteLine("{0} + {1} = {2}", a, b, result);

			result = calc.sub(a, b);
			Console.WriteLine("{0} - {1} = {2}", a, b, result);

			Console.WriteLine("Press any Key...");
			Console.ReadLine();
			//Console.Read();
			//Console.ReadKey();
		}
	}
}
