﻿namespace Battleship.Util
{
    public class Input
    {
        public string Select()
        {
            return Console.ReadLine();
        }
        
        public bool InputValidation(int possibilities, string input)
        {
            string[] inputNumber = new string[possibilities];
            for (int i = 0; i < possibilities; i++)
            {
                inputNumber[i] = (i + 1).ToString();
            }
            if (inputNumber.Contains(input))
            {
                return true;
            }
            return false;
        }

        public int BoardSizeValidation()
        {
            while (true)
            {
                string size = Select();
                try
                {
                    if (int.Parse(size) >= 10 && int.Parse(size) <= 20)
                    {
                        return int.Parse(size);
                    }
                    new Display().Message("Please provide a number between 10 and 20!");
                }
                catch (FormatException)
                {
                    new Display().Message("Please provide a number between 10 and 20!");
                }
            }
        }

        public List<int, int, int> PlacementValidation(string input)
        {
            while (true)
            {
                if (input.Length == 3 && Char.IsLetter(input[0]) && Char.IsDigit(input[1]) && Char.IsLetter(input[2]))
                {
                    int row = char.ToUpper(input[0]) - 65;
                    int col = (input[1] - '0') - 1;
                    Direction direction;

                    if (Char.ToUpper(input[2]) == 'H')
                    {
                        direction = Direction.Horizontal;
                    }
                    else if (Char.ToUpper(input[2]) == 'V')
                    {
                        direction = Direction.Vertical;
                    }
                    else
                    {
                        new Display().Message("Not valid direction!");
                        continue;
                    }

                    return List<int, int, int>(row, col, 3);



                }
            }
        }
    }
}
