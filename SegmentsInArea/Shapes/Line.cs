using System.Drawing;

namespace SegmentsInArea.Shapes
{
	public class Line
	{
		public Color LineColor { get; set; }
		public float LineWidth { get; set; }
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
	}
}