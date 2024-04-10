namespace ExerciseOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);

            //int m = int.Parse(Console.ReadLine());
            //bool isBase = true;
            //for (int i = 2; i < m; i++)
            //{
            //    if(m % i == 0)
            //    {
            //        isBase = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isBase);

            decimal[] euro = { 3m, 6m, 9m, 12m, 15m, 18m };
            decimal[] usd = { 3.25m, 6.5m, 9.75m, 13m, 16.25m, 19.5m };

            bool areEqual = true;
            for (int i = 0; i < euro.Length; i++)
            {
                if ((euro[i] * 1.95m) != (usd[i] * 1.80m))
                {
                    areEqual = false;
                    break;
                }
            }

            Console.WriteLine(areEqual);
        }
    }
}
