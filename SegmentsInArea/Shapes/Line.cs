using System;
using System.Drawing;

namespace SegmentsInArea.Shapes
{
	public class Line
	{
		public Color LineColor { get; set; }
		public float LineWidth { get; set; }
		public bool IsSelected { get; set; }
		public Point Start { get; set; }
		public Point End { get; set; }

		public Line(Color color, float width, Point start, Point end)
		{
			LineColor = color;
			LineWidth = width;
			Start = start;
			End = end;
		}

		public void Draw(Graphics graphics)
		{
			using var pen = new Pen(LineColor, LineWidth);
			graphics.DrawLine(pen, Start, End);
		}

		public bool HitTest(Point point)
		{
			// проверка на то что мы не попали  в boundingBox линии
			if ((point.X < Start.X && point.X < End.X) || (point.X > Start.X && point.X > End.X) ||
			    (point.Y < Start.Y && point.Y < End.Y) || (point.Y > Start.Y && point.Y > End.Y))
				return false;

			// рассчитываем расстояние от точки до прямой
			float dy = End.Y - Start.Y;
			float dx = End.X - Start.X;
			float nominator = dy * point.X - dx * point.Y + Start.Y * End.X - Start.X * End.Y;
			float denominator = dy * dy + dx * dx;
			float dist = (float)(Math.Abs(nominator) / Math.Sqrt(denominator));

			// проверяем, что полученное расстояние не больше ширины линии
			return dist < LineWidth / 2f;
		}
	}
}