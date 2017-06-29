using System;
using System.Collections.Generic;

namespace BasicOOP
{
	public class VerticalLine : Figure
	{
		public VerticalLine(int yUp, int yDown, int x, char sym)
		{
			pList = new List<Point>();

			for (int y = yUp; yUp < yDown; y++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}
	}
}
