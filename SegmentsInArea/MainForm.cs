using System.Drawing;
using System.Windows.Forms;

namespace SegmentsInArea
{
	public partial class MainForm : DevExpress.XtraEditors.XtraForm
	{
		private Bitmap _bitmap;
		private Graphics _graphics;
		private Pen _pen;
		private Point _px, _py;

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
			_isPaint = true;
			_py = e.Location;

			_cX = e.X;
			_cY = e.Y;
		}

		private void pictureBoxDrawing_MouseMove(object sender, MouseEventArgs e)
		{
			if (_isPaint)
			{
				if (_index == 3)
				{
					_px = e.Location;
					_graphics.DrawLine(_pen, _px, _py);
					_py = _px;
				}
			}
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
				_graphics.DrawRectangle(_pen, _cX, _cY, _sX, _sY);
			}
		}

		private void btn_line_Click(object sender, System.EventArgs e)
		{
			_index = 1;
			btn_rect.Checked = false;
		}

		private void btn_rect_Click(object sender, System.EventArgs e)
		{
			_index = 2;
			btn_line.Checked = false;
		}

		private void simpleButton1_Click(object sender, System.EventArgs e)
		{
			_graphics.Clear(Color.White);
			pic_canvas.Image = _bitmap;
			_index = 0;

			btn_line.Checked = false;
			btn_rect.Checked = false;
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
						graphics.DrawRectangle(_pen, _cX, _cY, _sX, _sY);
						break;
				}
			}
		}
	}
}
