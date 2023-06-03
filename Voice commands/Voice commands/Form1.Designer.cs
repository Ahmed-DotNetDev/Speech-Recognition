namespace Voice_commands
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
			this.txt = new System.Windows.Forms.RichTextBox();
			this.btntalk = new System.Windows.Forms.Button();
			this.btnpause = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt
			// 
			this.txt.Location = new System.Drawing.Point(46, 30);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(248, 42);
			this.txt.TabIndex = 0;
			this.txt.Text = "";
			// 
			// btntalk
			// 
			this.btntalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntalk.Location = new System.Drawing.Point(179, 92);
			this.btntalk.Name = "btntalk";
			this.btntalk.Size = new System.Drawing.Size(115, 32);
			this.btntalk.TabIndex = 1;
			this.btntalk.Text = "Talk";
			this.btntalk.UseVisualStyleBackColor = true;
			this.btntalk.Click += new System.EventHandler(this.btntalk_Click);
			// 
			// btnpause
			// 
			this.btnpause.Enabled = false;
			this.btnpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnpause.Location = new System.Drawing.Point(46, 92);
			this.btnpause.Name = "btnpause";
			this.btnpause.Size = new System.Drawing.Size(114, 32);
			this.btnpause.TabIndex = 2;
			this.btnpause.Text = "Pause Talk";
			this.btnpause.UseVisualStyleBackColor = true;
			this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(345, 166);
			this.Controls.Add(this.btnpause);
			this.Controls.Add(this.btntalk);
			this.Controls.Add(this.txt);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SPEECH RECOGNITION";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox txt;
		private System.Windows.Forms.Button btntalk;
		private System.Windows.Forms.Button btnpause;
	}
}

