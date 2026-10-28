using tyiu.cources.programming.interfaces.Sprint3;

namespace Tyiu.TinkovSS.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        public int GetCountOfDivisors(int startValue, int stopValue)
        {
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Ищем делители, которые строго меньше 12
                for (int d = 1; d < 12; d++)
                {
                    if (x % d == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}