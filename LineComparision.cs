using System;


namespace LineComparisonComputation
{
    class LineComparision
    {
        public int X_One;
        public int X_Two;
        public int Y_One;
        public int Y_Two;
        public int S_One;
        public int S_Two;
        public int R_One;
        public int R_Two;
        public double LengthOfXY;
        public double LengthOfSR;
        public void lengthOFLine()
        {

            Console.WriteLine("... Welcome to Line Comparison Computation ... ");
            Console.WriteLine("Enter x, y co ordinates of the line 1 :");

            Console.WriteLine("Enter value X1");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale X2");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x, y co ordinates of the line 2 :");

            Console.WriteLine("Enter value of S1");
            int S1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of S2");
            int S2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R1");
            int R1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale R2");
            int R2 = Convert.ToInt32(Console.ReadLine());

            double LengthOfXY = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Value 1 is:: " + LengthOfXY);

            double LengthOfSR = Math.Sqrt(Math.Pow((S2 - S1), 2) + Math.Pow((R2 - R1), 2));
            Console.WriteLine("Length of Value 2 is: " + LengthOfSR);

            bool equalToResult = LengthOfXY.Equals(LengthOfSR);

            if (equalToResult == false)
            {
                Console.WriteLine("Therefore, Lines LengthOfXY and LengthOfSR are NOT Equal.");
            }
            else
            {
                Console.WriteLine("Therefore, Lines LengthOfXY and LengthOfSR are Equal.");
            }

            double Differene = LengthOfXY.CompareTo(LengthOfSR);
            if (Differene < 0)
            {
                Console.WriteLine("Length of Line LengthOfXY is less than LengthOfSR.");
            }
            if (Differene > 0)
            {
                Console.WriteLine("Length of Line LengthOfXY is greater than LengthOfSR.");
            }
            if (Differene == 0)
            {
                Console.WriteLine("Both Lines are equal in Length.");
            }
            Console.ReadKey();
        }
    }

}
