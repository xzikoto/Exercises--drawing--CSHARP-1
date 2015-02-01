using System;

namespace Eggcelent
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// If you want to color the console put this before and after Console.Wite();
			// Console.ForegroundColor = Console.Color.Yellow;
			// Console.Write();
			//Console.ForegroundColor = Console.Color.Gray;

			int n = int.Parse (Console.ReadLine ());
			int height = 2 * n;
			int width = 3 * n + 1;
			for (int rows = 0; rows < height; rows++) {

				for (int columns = 0; columns < width; columns++) {

					if ((columns  > n && columns < 2 * n) && (rows == 0 || rows == height - 1)) 
					{
						Console.Write('*');
					}
					else if ((rows >= n / 2 && rows < 2 * n - n / 2 ) &&(columns == 1 || columns == width - 2)) 
					{
						Console.Write('*');
					}
					else if (2 * rows - columns == - (2 * n - 1)||
						2 * rows - columns == 3 * n - 3) 
					{
						Console.Write('*');

					}
						
					else if (2 * rows + columns == n + 1 || // left-top
						2 * rows + columns == 6 * n - 3) // right-bottom
					{
						Console.Write('*');
					}

					else if ((rows == n - 1 || rows == n) && 
						(columns > 1 && columns < width - 2) && 
						(rows + columns) % 2 == 1) {
						Console.Write('@');
					}


					else 
					{
						Console.Write('.');
					}


				}
				Console.WriteLine ();
			}
		}
	}
}
