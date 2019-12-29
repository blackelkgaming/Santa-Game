using System;

namespace Classes
{
    public static class RandNum
    {
        public static int GetNumTo(int max)
        {
            Random random = new Random();
            return random.Next(0, max);
        }
    }
}