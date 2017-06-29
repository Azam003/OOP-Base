using System;

namespace BasicOOP
{
	public class Point
	{
		public int x;
		public int y;
		public char sym;

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(sym);
		}

		// Конструкторы
		public Point(int _x, int _y, char _sym) 
		{
			x = _x;
			y = _y;
			sym = _sym;
		}
	}
}
