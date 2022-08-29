namespace cproyects
{
    static class Methods
    {
        public static int FibonnaciSucession(int num) => num <= 1 ? num : FibonnaciSucession(num - 1) + FibonnaciSucession(num - 2);

        public static void FibonnaciSucessionV2(int limit)
        {
            int numAnt = 0,
                numAct = 1,
                plus = 0;

            for(int i = 0; i <= limit; i++)
            {
                Console.Write($" {plus}, ");
                    
                numAnt = numAct;
                numAct = plus;
                plus = numAnt + numAct;
            }
        }

        public static void DrawChristmasTree()
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 7; j += 2)
                {
                    for (var k = 0; k < (7 - j) / 2; k++)
                    {
                        Console.Write(" ");
                    }
                    for (var m = 0; m <= j; m++)
                    {
                        Console.Write("*");
                    }
                    for (var n = (7 - j) / 2; n < 7; n++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    
        public static void SieveOfEratosthenes(int limit)
        {
            for(int i = 1; i <= limit; i++)
            {
                if(i > 5 && i/2 == 1 && i/3 == 1 && i/5==1)
                {
                    Console.Write($" {i}, ");
                }
            }
        }

        ///<summary>
        /// This method print prime's numbers
        ///</summary>
        ///<returns>
        /// always return an integer
        ///</returns>
        ///<param name="number">A number to return</param>
        public static int ReturnAnInteger(int number)
        {
            if(number == 5)
                throw new HttpRequestException();
            return number;
        }
    }
}