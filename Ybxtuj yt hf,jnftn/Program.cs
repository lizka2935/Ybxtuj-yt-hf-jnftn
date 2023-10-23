using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ybxtuj_yt_hf_jnftn
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int consultationTime = 30;
            TimeSpan[] startTimes = { new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), new TimeSpan(15, 0, 0), new TimeSpan(15, 30, 00), new TimeSpan(16, 50, 00) };
            int[] durations = { 60, 30, 10, 10, 40 };
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            TimeSpan interval;
            interval = new TimeSpan(0, consultationTime, 0);
            
            TimeSpan pause;
            TimeSpan resume;
            

            while (beginWorkingTime <= endWorkingTime)
            {
                for (int i = 0; i < durations.Length; i++)
                {
                    pause = new TimeSpan(0, durations[i], 0);
                    resume = pause + startTimes[i];
                }
                
                Console.WriteLine(beginWorkingTime);
                beginWorkingTime = beginWorkingTime + interval;

            }
            Console.ReadKey();
        }
    }
}
