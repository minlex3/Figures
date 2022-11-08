namespace Figures
{
    public class Utils
    {
        public class Constants
        {
            public const double CalculationAccuracy = 1e-6;
            public const double MinimalRadius = CalculationAccuracy * 10;
        }

        public static void SortingArray(double[] arr)
        {
            double temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
