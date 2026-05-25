using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.Queue
{
    public class Dota2Senate
    {
        public static string ExecuteSolution(string s)
        {
            Console.WriteLine("28: Dota2 Senate :" + s);
            return PredictPartyVictory(s);
        }

        public static string PredictPartyVictory(string senate)
        {
            string result = "";
            int index = 0;
            Queue<int> R = new Queue<int>();
            Queue<int> D = new Queue<int>();
            foreach (char c in senate) 
            {
                if (c == 'R') R.Enqueue(index);
                if (c == 'D') D.Enqueue(index);
                index++;
            }

            while (R.Count > 0 && D.Count > 0)
            {
                int popR = R.Dequeue();
                int popD = D.Dequeue();
                if (popR > popD) D.Enqueue(popD + senate.Length);
                else R.Enqueue(popR + senate.Length);
            }

            return (R.Count != 0) ? "Radiant" : "Dire";
        }
    }
}
