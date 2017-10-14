using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The IronPython and Dynamic Language Runtime (DLR)
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;

namespace pyControlWinForm
{
	public class PythonNet
	{
		private ScriptEngine pyEgine = null;
		private ScriptScope pyScope = null;


		/// <summary>
		///Initialize the Engine and set up the Scope
		// The scope is a container which holds the variables, functions and classes
		// and groups them together.
		/// </summary>
		public PythonNet()
		{

			pyEgine = Python.CreateEngine();
			pyScope = pyEgine.CreateScope();
		}


		/// <summary>
		/// generating, compiling, asnd executing IronPython code <selectCode : "1='Python File, 2='code string">
		/// </summary>
		/// <param name="pyFileFullPath"></param>/
		/// <param name="selectCode"></param>
		public void CompileSourceAndExecute(string pyFileFullPathOrCode, int selectCode)
		{
			ScriptSource source = null;
			if (selectCode == 1)
			{
				source = pyEgine.CreateScriptSourceFromFile(pyFileFullPathOrCode);
			}
			else
			{
				source = pyEgine.CreateScriptSourceFromString(pyFileFullPathOrCode, SourceCodeKind.Statements);
			}

			CompiledCode compiled = source.Compile();
			// Execute wirhin the scope which is defined
			compiled.Execute(pyScope);
		}


		/// <summary>
		/// Adding defined by python script to scope
		/// </summary>
		/// <param name="name"></param>
		/// <param name="obj"></param>
		public void AddToScope(string name, object obj)
		{
			pyScope.SetVariable(name, obj);
		}
	}
}
