using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//reference to ControlForm class
using pyControlWinForm;


namespace pyInteractWithWinForm
{
	public partial class MainForm : Form
	{
		private PythonNet pythonNet = null;
		public MainForm()
		{
			InitializeComponent();

			//Add these .NET types to scope to use in python code
			pythonNet.AddToScope("ExeFromCode", ExeFromCode);
			pythonNet.AddToScope("ExeFromFile", ExeFromFile);
			pythonNet.AddToScope("CoingTextBox", CoingTextBox);
			pythonNet.AddToScope("titleLabel", titleLabel);
		}

		private void ExeFromCode_Click(object sender, EventArgs e)
		{
			try
			{
				pythonNet.CompileSourceAndExecute(this.CoingTextBox.Text, 2);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, ex.GetType().ToString(),
				  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
	}
}
