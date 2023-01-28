using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraPrinting;

namespace SegmentsInArea
{
	public partial class MainForm : DevExpress.XtraEditors.XtraForm
	{
		private readonly Bitmap _bitmap;
		private readonly Graphics _graphics;
		private readonly Pen _pen;

		private bool _isPaint;
		private int _index;

		private int _x, _y, _sX, _sY, _cX, _cY;

		public MainForm()
		{
			InitializeComponent();

			this.Width = 800;
			this.Height = 600;

			_bitmap = new Bitmap(pic_canvas.Width, pic_canvas.Height);
			_graphics = Graphics.FromImage(_bitmap);
			_graphics.Clear(Color.White);
			_pen = new Pen(Color.Black, 1);
			
			pic_canvas.Image = _bitmap;
		}

		private void pictureBoxDrawing_MouseDown(object sender, MouseEventArgs e)
		{
			_sX = _sY = 0;
			_isPaint = true;
			_py = e.Location;

			_cX = e.X;
			_cY = e.Y;
		}

		private void pictureBoxDrawing_MouseMove(object sender, MouseEventArgs e)
		{
			pic_canvas.Refresh();
			
			//Если мышь движется, то устанавливаем точки начала и конца,
			//чтобы получить ширину и высоту фигуры
			_x = e.X;
			_y = e.Y;
			_sX = e.X - _cX;
			_sY = e.Y - _cY;
		}

		private void pictureBoxDrawing_MouseUp(object sender, MouseEventArgs e)
		{
			_isPaint = false;

			_sX = _x - _cX;
			_sY = _y - _cY;

			if (_index == 1)
			{
				_graphics.DrawLine(_pen, _cX, _cY, _x, _y);
			}

			if (_index == 2)
			{
				var rect = GetRectangle();
				_graphics.DrawRectangle(_pen, rect);
			}
		}

		private void btn_line_Click(object sender, EventArgs e)
		{
			_index = 1;
			btn_rect.Checked = false;
		}

		private void btn_rect_Click(object sender, EventArgs e)
		{
			_index = 2;
			btn_line.Checked = false;
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			_graphics.Clear(Color.White);
			pic_canvas.Image = _bitmap;
		}
		
		private void pic_canvas_Paint(object sender, PaintEventArgs e)
		{
			var graphics = e.Graphics;

			if (_isPaint)
			{
				switch (_index)
				{
					case 1:
						graphics.DrawLine(_pen, _cX, _cY, _x, _y);
						break;
					case 2:
						var rect = GetRectangle();
						graphics.DrawRectangle(_pen, rect);
						break;
				}
			}
		}

		private Rectangle GetRectangle()
		{
			var x = _x < _cX ? _x : _cX;
			var y = _y < _cY ? _y : _cY;
			return new Rectangle(x, y, Math.Abs(_sX), Math.Abs(_sY));
		}
	}
}
