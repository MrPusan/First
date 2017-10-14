namespace pyInteractWithWinForm
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.titleLabel = new System.Windows.Forms.Label();
			this.CoingTextBox = new System.Windows.Forms.RichTextBox();
			this.ExeFromFile = new System.Windows.Forms.Button();
			this.ExeFromCode = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.titleLabel.Location = new System.Drawing.Point(24, 20);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(610, 34);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "title";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CoingTextBox
			// 
			this.CoingTextBox.Location = new System.Drawing.Point(22, 61);
			this.CoingTextBox.Name = "CoingTextBox";
			this.CoingTextBox.Size = new System.Drawing.Size(611, 141);
			this.CoingTextBox.TabIndex = 1;
			this.CoingTextBox.Text = "";
			// 
			// ExeFromFile
			// 
			this.ExeFromFile.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ExeFromFile.Location = new System.Drawing.Point(23, 215);
			this.ExeFromFile.Name = "ExeFromFile";
			this.ExeFromFile.Size = new System.Drawing.Size(294, 38);
			this.ExeFromFile.TabIndex = 2;
			this.ExeFromFile.Text = "Execute from File";
			this.ExeFromFile.UseVisualStyleBackColor = true;
			// 
			// ExeFromCode
			// 
			this.ExeFromCode.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ExeFromCode.Location = new System.Drawing.Point(339, 215);
			this.ExeFromCode.Name = "ExeFromCode";
			this.ExeFromCode.Size = new System.Drawing.Size(294, 38);
			this.ExeFromCode.TabIndex = 3;
			this.ExeFromCode.Text = "Execute from code";
			this.ExeFromCode.UseVisualStyleBackColor = true;
			this.ExeFromCode.Click += new System.EventHandler(this.ExeFromCode_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 261);
			this.Controls.Add(this.ExeFromCode);
			this.Controls.Add(this.ExeFromFile);
			this.Controls.Add(this.CoingTextBox);
			this.Controls.Add(this.titleLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.RichTextBox CoingTextBox;
		private System.Windows.Forms.Button ExeFromFile;
		private System.Windows.Forms.Button ExeFromCode;
	}
}