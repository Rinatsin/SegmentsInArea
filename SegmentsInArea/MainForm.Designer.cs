
namespace SegmentsInArea
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pic_canvas = new System.Windows.Forms.PictureBox();
			this.panelSettings = new DevExpress.XtraEditors.PanelControl();
			this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_rect = new DevExpress.XtraEditors.CheckButton();
			this.btn_line = new DevExpress.XtraEditors.CheckButton();
			this.labelCaptionSettings = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.pic_canvas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelSettings)).BeginInit();
			this.panelSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// pic_canvas
			// 
			this.pic_canvas.BackColor = System.Drawing.Color.White;
			this.pic_canvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pic_canvas.Location = new System.Drawing.Point(0, 0);
			this.pic_canvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pic_canvas.Name = "pic_canvas";
			this.pic_canvas.Size = new System.Drawing.Size(737, 342);
			this.pic_canvas.TabIndex = 0;
			this.pic_canvas.TabStop = false;
			this.pic_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_canvas_Paint);
			this.pic_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseDown);
			this.pic_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseMove);
			this.pic_canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseUp);
			// 
			// panelSettings
			// 
			this.panelSettings.Controls.Add(this.btn_clear);
			this.panelSettings.Controls.Add(this.label2);
			this.panelSettings.Controls.Add(this.label1);
			this.panelSettings.Controls.Add(this.btn_rect);
			this.panelSettings.Controls.Add(this.btn_line);
			this.panelSettings.Controls.Add(this.labelCaptionSettings);
			this.panelSettings.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelSettings.Location = new System.Drawing.Point(559, 0);
			this.panelSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panelSettings.Name = "panelSettings";
			this.panelSettings.Size = new System.Drawing.Size(178, 342);
			this.panelSettings.TabIndex = 1;
			// 
			// btn_clear
			// 
			this.btn_clear.Location = new System.Drawing.Point(6, 145);
			this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(167, 27);
			this.btn_clear.TabIndex = 5;
			this.btn_clear.Text = "Очистить";
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(70, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 34);
			this.label2.TabIndex = 4;
			this.label2.Text = "Прямоугольная\r\nобласть";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Отрезок";
			// 
			// btn_rect
			// 
			this.btn_rect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.btn_rect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_rect.ImageOptions.Image")));
			this.btn_rect.Location = new System.Drawing.Point(6, 79);
			this.btn_rect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_rect.Name = "btn_rect";
			this.btn_rect.Size = new System.Drawing.Size(43, 46);
			this.btn_rect.TabIndex = 2;
			this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
			// 
			// btn_line
			// 
			this.btn_line.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.btn_line.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_line.ImageOptions.Image")));
			this.btn_line.Location = new System.Drawing.Point(6, 26);
			this.btn_line.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_line.Name = "btn_line";
			this.btn_line.Size = new System.Drawing.Size(43, 46);
			this.btn_line.TabIndex = 1;
			this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
			// 
			// labelCaptionSettings
			// 
			this.labelCaptionSettings.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCaptionSettings.Appearance.Options.UseFont = true;
			this.labelCaptionSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelCaptionSettings.Location = new System.Drawing.Point(2, 2);
			this.labelCaptionSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.labelCaptionSettings.Name = "labelCaptionSettings";
			this.labelCaptionSettings.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.labelCaptionSettings.Size = new System.Drawing.Size(62, 17);
			this.labelCaptionSettings.TabIndex = 0;
			this.labelCaptionSettings.Text = "Фигуры";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 342);
			this.Controls.Add(this.panelSettings);
			this.Controls.Add(this.pic_canvas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "Segments In Area";
			((System.ComponentModel.ISupportInitialize)(this.pic_canvas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelSettings)).EndInit();
			this.panelSettings.ResumeLayout(false);
			this.panelSettings.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pic_canvas;
		private DevExpress.XtraEditors.PanelControl panelSettings;
		private DevExpress.XtraEditors.LabelControl labelCaptionSettings;
		private DevExpress.XtraEditors.CheckButton btn_line;
		private DevExpress.XtraEditors.CheckButton btn_rect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.SimpleButton btn_clear;
	}
}

