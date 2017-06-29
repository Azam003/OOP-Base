using System;
using System.Collections.Generic;

namespace BasicOOP
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Point p1 = new Point(1, 3, '*');
			p1.Draw();


			Point p2 = new Point(2, 6, '#');
			p2.Draw();

			HorizontalLine upLine = new HorizontalLine(0, 20, 0, '*');
			upLine.Drow();
			HorizontalLine downLine = new HorizontalLine(0, 20, 20, '*');
			downLine.Drow();

			VerticalLine leftLine = new VerticalLine(0, 20, 0, '*');
			leftLine.Drow();
			VerticalLine rightLine = new VerticalLine(0, 20, 20, '*');
			rightLine.Drow();
		}
	}
}
