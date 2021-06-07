namespace AddDigits
{
    /// <summary>
    /// Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var prg = new Program();
            var result1 = prg.AddDigits(38); //2
            var result2 = prg.AddDigits(0); //0
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int AddDigits(int num)
        {
            return GetDightsSum(num);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private int GetDightsSum(int num)
        {
            var s = 0;
            while (num > 0)
            {
                var a = num % 10;
                s += a;
                num = num / 10;
            }
            if (s < 10)
                return s;

            return GetDightsSum(s);
        }
    }

    
}
