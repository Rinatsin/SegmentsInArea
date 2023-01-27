
namespace SegmentsInArea
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBoxDrawing = new System.Windows.Forms.PictureBox();
			this.panelSettings = new DevExpress.XtraEditors.PanelControl();
			this.labelCaptionSettings = new DevExpress.XtraEditors.LabelControl();
			this.checkButtonLine = new DevExpress.XtraEditors.CheckButton();
			this.checkButtonRect = new DevExpress.XtraEditors.CheckButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelSettings)).BeginInit();
			this.panelSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxDrawing
			// 
			this.pictureBoxDrawing.BackColor = System.Drawing.Color.White;
			this.pictureBoxDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxDrawing.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxDrawing.Name = "pictureBoxDrawing";
			this.pictureBoxDrawing.Size = new System.Drawing.Size(632, 278);
			this.pictureBoxDrawing.TabIndex = 0;
			this.pictureBoxDrawing.TabStop = false;
			// 
			// panelSettings
			// 
			this.panelSettings.Controls.Add(this.label2);
			this.panelSettings.Controls.Add(this.label1);
			this.panelSettings.Controls.Add(this.checkButtonRect);
			this.panelSettings.Controls.Add(this.checkButtonLine);
			this.panelSettings.Controls.Add(this.labelCaptionSettings);
			this.panelSettings.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelSettings.Location = new System.Drawing.Point(479, 0);
			this.panelSettings.Name = "panelSettings";
			this.panelSettings.Size = new System.Drawing.Size(153, 278);
			this.panelSettings.TabIndex = 1;
			// 
			// labelCaptionSettings
			// 
			this.labelCaptionSettings.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCaptionSettings.Appearance.Options.UseFont = true;
			this.labelCaptionSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelCaptionSettings.Location = new System.Drawing.Point(2, 2);
			this.labelCaptionSettings.Name = "labelCaptionSettings";
			this.labelCaptionSettings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.labelCaptionSettings.Size = new System.Drawing.Size(50, 13);
			this.labelCaptionSettings.TabIndex = 0;
			this.labelCaptionSettings.Text = "Фигуры";
			// 
			// checkButtonLine
			// 
			this.checkButtonLine.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.checkButtonLine.Checked = true;
			this.checkButtonLine.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("checkButtonLine.ImageOptions.Image")));
			this.checkButtonLine.Location = new System.Drawing.Point(5, 21);
			this.checkButtonLine.Name = "checkButtonLine";
			this.checkButtonLine.Size = new System.Drawing.Size(37, 37);
			this.checkButtonLine.TabIndex = 1;
			// 
			// checkButtonRect
			// 
			this.checkButtonRect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.checkButtonRect.Checked = true;
			this.checkButtonRect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("checkButtonRect.ImageOptions.Image")));
			this.checkButtonRect.Location = new System.Drawing.Point(5, 64);
			this.checkButtonRect.Name = "checkButtonRect";
			this.checkButtonRect.Size = new System.Drawing.Size(37, 37);
			this.checkButtonRect.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Отрезок";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 26);
			this.label2.TabIndex = 4;
			this.label2.Text = "Прямоугольная\r\nобласть";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 278);
			this.Controls.Add(this.panelSettings);
			this.Controls.Add(this.pictureBoxDrawing);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Segments In Area";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelSettings)).EndInit();
			this.panelSettings.ResumeLayout(false);
			this.panelSettings.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxDrawing;
		private DevExpress.XtraEditors.PanelControl panelSettings;
		private DevExpress.XtraEditors.LabelControl labelCaptionSettings;
		private DevExpress.XtraEditors.CheckButton checkButtonLine;
		private DevExpress.XtraEditors.CheckButton checkButtonRect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

