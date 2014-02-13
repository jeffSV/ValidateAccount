namespace JustAProjectToTest
{
	partial class Form1
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
			this.btnPrint = new System.Windows.Forms.Button();
			this.txtbxMsg = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(12, 22);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 0;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.OnPrint);
			// 
			// txtbxMsg
			// 
			this.txtbxMsg.Location = new System.Drawing.Point(93, 25);
			this.txtbxMsg.Name = "txtbxMsg";
			this.txtbxMsg.Size = new System.Drawing.Size(100, 20);
			this.txtbxMsg.TabIndex = 1;
			this.txtbxMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 266);
			this.Controls.Add(this.txtbxMsg);
			this.Controls.Add(this.btnPrint);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.TextBox txtbxMsg;
	}
}

