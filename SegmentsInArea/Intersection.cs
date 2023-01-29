﻿using System.Drawing;

namespace SegmentsInArea
{
	public static class Intersection
	{
		public static bool LineIntersectsRect(Point p1, Point p2, Rectangle r)
		{
			return LineIntersectsLine(p1, p2, new Point(r.X, r.Y), new Point(r.X + r.Width, r.Y)) ||
			       LineIntersectsLine(p1, p2, new Point(r.X + r.Width, r.Y), new Point(r.X + r.Width, r.Y + r.Height)) ||
			       LineIntersectsLine(p1, p2, new Point(r.X + r.Width, r.Y + r.Height), new Point(r.X, r.Y + r.Height)) ||
			       LineIntersectsLine(p1, p2, new Point(r.X, r.Y + r.Height), new Point(r.X, r.Y)) ||
			       (r.Contains(p1) && r.Contains(p2));
		}

		private static bool LineIntersectsLine(Point l1p1, Point l1p2, Point l2p1, Point l2p2)
		{
			//Рассчитываю направление линий 
			float q = (l1p1.Y - l2p1.Y) * (l2p2.X - l2p1.X) - (l1p1.X - l2p1.X) * (l2p2.Y - l2p1.Y);
			float d = (l1p2.X - l1p1.X) * (l2p2.Y - l2p1.Y) - (l1p2.Y - l1p1.Y) * (l2p2.X - l2p1.X);

			//Если линии параллельны (d=0) и совпадают (q = 0)
			if (d == 0 && q == 0)
			{
				return true;
			}

			//Если просто параллельны
			if (d == 0)
			{
				return false;
			}

			float r = q / d;

			q = (l1p1.Y - l2p1.Y) * (l1p2.X - l1p1.X) - (l1p1.X - l2p1.X) * (l1p2.Y - l1p1.Y);
			float s = q / d;

			if (r < 0 || r > 1 || s < 0 || s > 1)
			{
				return false;
			}

			return true;
		}
	}
}
