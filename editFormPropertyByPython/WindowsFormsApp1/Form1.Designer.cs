namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.TitleLabel = new System.Windows.Forms.Label();
			this.CodingText = new System.Windows.Forms.RichTextBox();
			this.ExeFromFile = new System.Windows.Forms.Button();
			this.ExeFromCode = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TitleLabel.ForeColor = System.Drawing.Color.Red;
			this.TitleLabel.Location = new System.Drawing.Point(9, 11);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(652, 30);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Title";
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CodingText
			// 
			this.CodingText.Location = new System.Drawing.Point(12, 55);
			this.CodingText.Name = "CodingText";
			this.CodingText.Size = new System.Drawing.Size(648, 210);
			this.CodingText.TabIndex = 1;
			this.CodingText.Text = "";
			// 
			// ExeFromFile
			// 
			this.ExeFromFile.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ExeFromFile.Location = new System.Drawing.Point(16, 271);
			this.ExeFromFile.Name = "ExeFromFile";
			this.ExeFromFile.Size = new System.Drawing.Size(322, 35);
			this.ExeFromFile.TabIndex = 2;
			this.ExeFromFile.Text = "Execute From File";
			this.ExeFromFile.UseVisualStyleBackColor = true;
			this.ExeFromFile.Click += new System.EventHandler(this.ExeFromFile_Click);
			// 
			// ExeFromCode
			// 
			this.ExeFromCode.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ExeFromCode.Location = new System.Drawing.Point(344, 271);
			this.ExeFromCode.Name = "ExeFromCode";
			this.ExeFromCode.Size = new System.Drawing.Size(317, 35);
			this.ExeFromCode.TabIndex = 3;
			this.ExeFromCode.Text = "Execute From Above Code";
			this.ExeFromCode.UseVisualStyleBackColor = true;
			this.ExeFromCode.Click += new System.EventHandler(this.ExeFromCode_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 318);
			this.Controls.Add(this.ExeFromCode);
			this.Controls.Add(this.ExeFromFile);
			this.Controls.Add(this.CodingText);
			this.Controls.Add(this.TitleLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.RichTextBox CodingText;
		private System.Windows.Forms.Button ExeFromFile;
		private System.Windows.Forms.Button ExeFromCode;
	}
}

