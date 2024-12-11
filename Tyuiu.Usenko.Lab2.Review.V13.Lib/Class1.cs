namespace Tyuiu.Usenko.Lab2.Review.V13.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int start, int end)
        {
            if (start > end)
                return new double[0];
            double[] results = new double[end - start + 1];
            int index = 0;
            for (int x = start; x <= end; x++)
            {
                if (x == 1 || x == -1)
                {
                    results[index] = double.NaN;
                }
                else
                {
                    results[index] = Math.Cos(x) + (Math.Pow((x + 1), x)/Math.Pow((x - 1), x)) + 18 * Math.Pow(x, 2);
                    results[index] = Math.Round(results[index], 2);
                }
                index++;
            }
            return results;
        }
    }
}
