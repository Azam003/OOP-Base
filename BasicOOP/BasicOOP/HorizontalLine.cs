using System;
using System.Collections.Generic;

namespace BasicOOP
{
	public class HorizontalLine
	{
		List<Point> pList = new List<Point>();

		public HorizontalLine(int xLeft, int xRight, int y, char sym) 
		{
			for (int x = xLeft; x < xRight; x++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}

		public void Draw() 
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}
		}
	}
}
