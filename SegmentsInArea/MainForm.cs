using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SegmentsInArea.Shapes;

namespace SegmentsInArea
{
	public partial class MainForm : DevExpress.XtraEditors.XtraForm
	{
		private readonly Bitmap _bitmap;
		private readonly Graphics _graphics;

		private readonly Color _penColorBase;
		private readonly Color _penColorSelected;
		private readonly int _penWidth;

		private readonly List<Line> _lines;
		private readonly List<Line> _selectedLines;

		private bool _needRedraw;
		private bool _isPaint;
		private int _index;

		private int _x, _y, _dX, _dY, _cX, _cY;

		public MainForm()
		{
			InitializeComponent();

			Width = 800;
			Height = 600;

			_bitmap = new Bitmap(pic_canvas.Width, pic_canvas.Height);
			_graphics = Graphics.FromImage(_bitmap);
			_graphics.Clear(Color.White);
			_penColorBase = Color.Black;
			_penColorSelected = Color.Red;
			_penWidth = 1;

			pic_canvas.Image = _bitmap;

			_lines = new List<Line>();
			_selectedLines = new List<Line>();
		}

		private void pictureBoxDrawing_MouseDown(object sender, MouseEventArgs e)
		{
			_dX = _dY = 0;
			_isPaint = true;

			_cX = e.X;
			_cY = e.Y;
		}

		private void pictureBoxDrawing_MouseMove(object sender, MouseEventArgs e)
		{
			if (_isPaint)
			{
				//Если мы рисуем то при каждой новой итерации перерисовываем изображение
				pic_canvas.Invalidate();

				//Запоминаем текущие координаты мыши и рассчитываем расстояние
				_x = e.X;
				_y = e.Y;
				_dX = e.X - _cX;
				_dY = e.Y - _cY;
			}
		}

		private void pictureBoxDrawing_MouseUp(object sender, MouseEventArgs e)
		{
			_isPaint = false;

			_dX = _x - _cX;
			_dY = _y - _cY;

			//Финальная отрисовка линии
			if (_index == 1)
			{
				var start = new Point(_cX, _cY);
				var end = new Point(_x, _y);

				using var pen = new Pen(_penColorBase, _penWidth);
				var line = new Line(_penColorBase, _penWidth, start, end);
				line.Draw(_graphics);
				_lines.Add(line);
			}

			//Финальная отрисовка прямоугольника
			if (_index == 2)
			{
				var rect = GetRectangle();
				using var pen = new Pen(_penColorBase, _penWidth);
				_graphics.DrawRectangle(pen, rect);

				//Проверка вхождения в прямоугольную область
				foreach (var line in _lines.
					         Where(line => Intersection.LineIntersectsRect(line.Start, line.End, rect)))
				{
					line.LineColor = _penColorSelected;
					_selectedLines.Add(line);
				}
				//Удаляем из списка линий, линии, которые пересекаются с прямоугольником
				foreach (var selectedLine in _selectedLines.Where(selectedLine => _lines.Contains(selectedLine)))
				{
					_lines.Remove(selectedLine);
				}

				//Отображение списка линий в прямоугольной области
				rtb_lines.Text = string
					.Join(
							"\n", 
							_selectedLines
								.Select
									(line => $"Линия p1:{line.Start}  p2:{line.End}").ToArray());
				_needRedraw = true;
				pic_canvas.Invalidate();
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

		private void btn_clear_Click(object sender, EventArgs e)
		{
			_graphics.Clear(Color.White);
			pic_canvas.Image = _bitmap;
			_lines.Clear();
			_selectedLines.Clear();
			rtb_lines.Text = "";
		}
		
		private void pic_canvas_Paint(object sender, PaintEventArgs e)
		{
			var graphics = e.Graphics;

			//Рисование линий и прямоугольников
			if (_isPaint)
			{
				switch (_index)
				{
					case 1:
						using (var pen = new Pen(_penColorBase, _penWidth))
						{
							graphics.DrawLine(pen, _cX, _cY, _x, _y);
						}
						break;
					case 2:
						var rect = GetRectangle();
						using (var pen = new Pen(_penColorBase, _penWidth))
						{
							graphics.DrawRectangle(pen, rect);
						}
						break;
				}
			}

			//Перерисовать линии после расчета попадания в прямоугольную область
			if (_needRedraw)
			{
				_needRedraw = false;
				if (_selectedLines.Count > 0)
				{
					foreach (var line in _selectedLines)
					{
						line.Draw(graphics);
					}
				}
			}
		}

		/// <summary>
		/// Получить прямоугольную область
		/// </summary>
		/// <returns></returns>
		private Rectangle GetRectangle()
		{
			var x = _x < _cX ? _x : _cX;
			var y = _y < _cY ? _y : _cY;
			return new Rectangle(x, y, Math.Abs(_dX), Math.Abs(_dY));
		}
	}
}
