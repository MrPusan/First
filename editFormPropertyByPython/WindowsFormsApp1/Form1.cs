using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//The IronPython and Dynamic Language Runtime (DLR)
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;

//python intact with winform Lib.
using pyControlWinForm;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		private PythonNet pythonNet = null;

		public Form1()
		{
			InitializeComponent();

			pythonNet = new PythonNet();

			//Add these .NET types to scope to use in python code
			pythonNet.AddToScope("TitleLabel", TitleLabel);
			pythonNet.AddToScope("CodingText", CodingText);
			pythonNet.AddToScope("ExeFromFile", ExeFromFile);
			pythonNet.AddToScope("ExeFromCode", ExeFromCode);
		}

		private void ExeFromCode_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.CodingText.Text.Length == 0)
				{
					MessageBox.Show("python code를 입력하세요..", "Execute From code");
				}
				else
				{
					pythonNet.CompileSourceAndExecute(this.CodingText.Text, 2);
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, ex.GetType().ToString(),
				  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void ExeFromFile_Click(object sender, EventArgs e)
		{
			/*string path = Application.ExecutablePath;
			int index1 = path.IndexOf("bin");
			int index2 = path.Length;
			string Lpath = "";
			if (index1 >= 0)
			{
				Lpath = path.Remove(index1, index2 - index1);
			}
			else
			{
				Lpath = path;
			}*/
			
			string fileName = "test.py";

			//string fullPath = Lpath + fileName;
			try
			{
				//pythonNet.CompileSourceAndExecute(fullPath, 1);
				pythonNet.CompileSourceAndExecute(fileName, 1);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, ex.GetType().ToString(),
				  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			TitleLabel.Text = "Write the python code in the following textbox if you wnat to execute from code...";
		}
	}
}
