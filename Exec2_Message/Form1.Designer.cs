namespace Exec2_Message
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.resultbtn = new System.Windows.Forms.Button();
			this.resultlbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// resultbtn
			// 
			this.resultbtn.Location = new System.Drawing.Point(84, 75);
			this.resultbtn.Name = "resultbtn";
			this.resultbtn.Size = new System.Drawing.Size(99, 34);
			this.resultbtn.TabIndex = 0;
			this.resultbtn.Text = "顯示";
			this.resultbtn.UseVisualStyleBackColor = true;
			this.resultbtn.Click += new System.EventHandler(this.resultbtn_Click);
			// 
			// resultlbl
			// 
			this.resultlbl.Location = new System.Drawing.Point(236, 75);
			this.resultlbl.Name = "resultlbl";
			this.resultlbl.Size = new System.Drawing.Size(180, 65);
			this.resultlbl.TabIndex = 1;
			this.resultlbl.Text = "resultlbl";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 251);
			this.Controls.Add(this.resultlbl);
			this.Controls.Add(this.resultbtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button resultbtn;
		private System.Windows.Forms.Label resultlbl;
	}
}

