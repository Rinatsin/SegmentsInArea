
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
			this.lbl_Shapes = new DevExpress.XtraEditors.LabelControl();
			this.rtb_lines = new System.Windows.Forms.RichTextBox();
			this.lbl_info = new DevExpress.XtraEditors.LabelControl();
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
			this.pic_canvas.Name = "pic_canvas";
			this.pic_canvas.Size = new System.Drawing.Size(790, 572);
			this.pic_canvas.TabIndex = 0;
			this.pic_canvas.TabStop = false;
			this.pic_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_canvas_Paint);
			this.pic_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseDown);
			this.pic_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseMove);
			this.pic_canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseUp);
			// 
			// panelSettings
			// 
			this.panelSettings.Controls.Add(this.lbl_info);
			this.panelSettings.Controls.Add(this.rtb_lines);
			this.panelSettings.Controls.Add(this.btn_clear);
			this.panelSettings.Controls.Add(this.label2);
			this.panelSettings.Controls.Add(this.label1);
			this.panelSettings.Controls.Add(this.btn_rect);
			this.panelSettings.Controls.Add(this.btn_line);
			this.panelSettings.Controls.Add(this.lbl_Shapes);
			this.panelSettings.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelSettings.Location = new System.Drawing.Point(567, 0);
			this.panelSettings.Name = "panelSettings";
			this.panelSettings.Size = new System.Drawing.Size(223, 572);
			this.panelSettings.TabIndex = 1;
			// 
			// btn_clear
			// 
			this.btn_clear.Location = new System.Drawing.Point(5, 118);
			this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(206, 22);
			this.btn_clear.TabIndex = 5;
			this.btn_clear.Text = "Очистить";
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Отрезок";
			// 
			// btn_rect
			// 
			this.btn_rect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.btn_rect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_rect.ImageOptions.Image")));
			this.btn_rect.Location = new System.Drawing.Point(5, 64);
			this.btn_rect.Name = "btn_rect";
			this.btn_rect.Size = new System.Drawing.Size(37, 37);
			this.btn_rect.TabIndex = 2;
			this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
			// 
			// btn_line
			// 
			this.btn_line.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.btn_line.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_line.ImageOptions.Image")));
			this.btn_line.Location = new System.Drawing.Point(5, 21);
			this.btn_line.Name = "btn_line";
			this.btn_line.Size = new System.Drawing.Size(37, 37);
			this.btn_line.TabIndex = 1;
			this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
			// 
			// lbl_Shapes
			// 
			this.lbl_Shapes.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_Shapes.Appearance.Options.UseFont = true;
			this.lbl_Shapes.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_Shapes.Location = new System.Drawing.Point(2, 2);
			this.lbl_Shapes.Name = "lbl_Shapes";
			this.lbl_Shapes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.lbl_Shapes.Size = new System.Drawing.Size(50, 13);
			this.lbl_Shapes.TabIndex = 0;
			this.lbl_Shapes.Text = "Фигуры";
			// 
			// rtb_lines
			// 
			this.rtb_lines.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.rtb_lines.Location = new System.Drawing.Point(2, 169);
			this.rtb_lines.Name = "rtb_lines";
			this.rtb_lines.Size = new System.Drawing.Size(219, 401);
			this.rtb_lines.TabIndex = 6;
			this.rtb_lines.Text = "";
			// 
			// lbl_info
			// 
			this.lbl_info.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_info.Appearance.Options.UseFont = true;
			this.lbl_info.Location = new System.Drawing.Point(6, 150);
			this.lbl_info.Name = "lbl_info";
			this.lbl_info.Size = new System.Drawing.Size(135, 13);
			this.lbl_info.TabIndex = 7;
			this.lbl_info.Text = "Список линий в области";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 572);
			this.Controls.Add(this.panelSettings);
			this.Controls.Add(this.pic_canvas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
		private DevExpress.XtraEditors.LabelControl lbl_Shapes;
		private DevExpress.XtraEditors.CheckButton btn_line;
		private DevExpress.XtraEditors.CheckButton btn_rect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.SimpleButton btn_clear;
		private System.Windows.Forms.RichTextBox rtb_lines;
		private DevExpress.XtraEditors.LabelControl lbl_info;
	}
}

