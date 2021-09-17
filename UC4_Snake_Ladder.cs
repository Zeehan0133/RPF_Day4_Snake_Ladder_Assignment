using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Assignment_Snake_Ladder
{
    class UC4_Snake_Ladder
    {
		public static int playerPosition = 0;
		static int diceValue;
		public static void WinnerPosition()
		{
			int no_Play = 0;
			int ladder = 1;
			int snake = 2;
			int winningPosition = 100;
			while (playerPosition <= winningPosition)
			{
				while (playerPosition != 100)
				{
					Random rNumber = new Random();
					diceValue = rNumber.Next(1, 7);
					Random rd = new Random();
					int optionCheck = rd.Next(0, 3);

					switch (optionCheck)
					{
						case 1:
							playerPosition = playerPosition + diceValue;
							Console.WriteLine("U got Ladder and your position is: " + playerPosition);
							break;

						case 2:
							playerPosition = playerPosition - diceValue;
							if (playerPosition < 0)
							{
								playerPosition = 0;
							}
							Console.WriteLine("U got Snake and your position is: " + playerPosition);
							break;

						case 0:
							Console.WriteLine("No Play and your position is: " + playerPosition);
							break;
					}
				}

			}
		}
	}
}
