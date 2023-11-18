namespace Shape
{
    public static class Shape
    {
        public static double FindArea(params double[] sides)
        {
            if (!isRight(sides))
                return 0;

            if (sides.Length == 1)
                return Math.PI * Math.Pow(sides[0], 2);

            //if (sides.Length == 2)
            //    return sides[0] * sides[1];

            if (sides.Length == 3)
            {
                double p = (sides[0] + sides[1] + sides[2]) / 2;
                return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
            }

            return 0;
        }


        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (!isRight(a, b, c))
                return false;

            return Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)
            || Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)
            || Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
        }

        private static bool isRight(params double[] sides)
        {
            if (sides.Length == 0)
                return false;

            foreach (var side in sides)
            {
                if (side <= 0)
                    return false;
            }

            if(sides.Length == 3)
            {
                if (sides[0] + sides[1] <= sides[2] || sides[1] + sides[2] <= sides[0] || sides[0] + sides[2] <= sides[1])
                    return false;
            }

            return true;
        }

        #region попытки
        //private static bool isRight(double a, double b, double c)
        //{
        //    if (a <= 0 || b <= 0 || c <= 0)
        //        return false;

        //    if (a + b <= c || a + c <= b || b + c <= a)
        //        return false;

        //    return true;
        //}

        //private static bool isRight(double radius)
        //{
        //    if (radius <= 0)
        //        return false;

        //    return true;
        //}
        //public static double FindArea(double radius)
        //{
        //    if (!isRight(radius))
        //        return 0;

        //    return Math.PI * radius * radius;
        //}

        //public static double FindArea(double a, double b, double c)
        //{
        //    if (!isRight(a, b, c))
        //        return 0;

        //    double p = (a + b + c) / 2;

        //    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        //}
        #endregion
    }
}