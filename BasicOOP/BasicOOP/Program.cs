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

			HorizontalLine hLine = new HorizontalLine(5, 20, 8, '*');
			HorizontalLine hLineDown = new HorizontalLine(5, 20, 16, '*');
			hLine.Draw();
			hLineDown.Draw();
		}
	}
}
