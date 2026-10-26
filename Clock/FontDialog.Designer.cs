namespace Clock
{
	partial class FontDialog
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
			this.comboBoxFont = new System.Windows.Forms.ComboBox();
			this.counterFontSize = new System.Windows.Forms.NumericUpDown();
			this.labelExample = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.counterFontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxFont
			// 
			this.comboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFont.FormattingEnabled = true;
			this.comboBoxFont.Location = new System.Drawing.Point(12, 11);
			this.comboBoxFont.Name = "comboBoxFont";
			this.comboBoxFont.Size = new System.Drawing.Size(443, 21);
			this.comboBoxFont.TabIndex = 0;
			this.comboBoxFont.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFont_SelectionChangeCommitted);
			// 
			// counterFontSize
			// 
			this.counterFontSize.Location = new System.Drawing.Point(461, 12);
			this.counterFontSize.Name = "counterFontSize";
			this.counterFontSize.Size = new System.Drawing.Size(92, 20);
			this.counterFontSize.TabIndex = 1;
			this.counterFontSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.counterFontSize.ValueChanged += new System.EventHandler(this.counterFontSize_ValueChanged);
			// 
			// labelExample
			// 
			this.labelExample.AutoSize = true;
			this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelExample.Location = new System.Drawing.Point(12, 63);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(191, 51);
			this.labelExample.TabIndex = 2;
			this.labelExample.Text = "Example";
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(363, 265);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(92, 25);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "Ok";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancle
			// 
			this.buttonCancle.Location = new System.Drawing.Point(461, 265);
			this.buttonCancle.Name = "buttonCancle";
			this.buttonCancle.Size = new System.Drawing.Size(92, 25);
			this.buttonCancle.TabIndex = 4;
			this.buttonCancle.Text = "Cancle";
			this.buttonCancle.UseVisualStyleBackColor = true;
			// 
			// FontDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 302);
			this.Controls.Add(this.buttonCancle);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.counterFontSize);
			this.Controls.Add(this.comboBoxFont);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "FontDialog";
			this.Text = "FontDialog";
			((System.ComponentModel.ISupportInitialize)(this.counterFontSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxFont;
		private System.Windows.Forms.NumericUpDown counterFontSize;
		private System.Windows.Forms.Label labelExample;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancle;
	}
}