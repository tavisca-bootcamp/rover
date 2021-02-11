using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rover
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Int32 c = 2;
            string upperLimit = Console.ReadLine();
            string[] upprLimit = upperLimit.Split(new[] { ' ' }, c);
            List<string> intial = new List<string>();
            List<string> operationRequired = new List<string>();
            string inti;
            while ((inti = Console.ReadLine())!="")
            {
                
                intial.Add(inti);
                string o = Console.ReadLine();
                operationRequired.Add(o);
               
            }
            string[] result = getFinalPostion(upprLimit,intial.ToArray(),operationRequired.ToArray());
            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
            Test();
            Console.ReadLine();
        }
        private static bool IsKillSwitch(ConsoleKeyInfo key)
        {
            return key.Key == ConsoleKey.C && key.Modifiers == ConsoleModifiers.Control;
        }

        public static void Test()
        {
            string[] upprLimit = new[] { "5", "5" };
            string[] intial = new[] { "1 2 N", "3 3 E" };
            string[] OrderSequence = new[] { "LMLMLMLMM", "MMRMMRMRRM" };
            string[] result = getFinalPostion(upprLimit, intial, OrderSequence);
             if(result[0] =="1 3 N" && result[1] == "5 1 E")
            {
                Console.WriteLine("PASS");
            }
            else {
                Console.WriteLine("FAIL"); }
             

        }
        public static  string[] getFinalPostion(string[] upprLimit,string[] initial,string[] OrderSequence)
        {
            int upperX = Int32.Parse(upprLimit[0]);
            string[] result = new string[initial.Length];
            int upperY = Int32.Parse(upprLimit[1]);
            for(int i=0;i<initial.Length;i++)
            {
                Int32 c = 3;
               string[] l = initial[i].Split(new[] { ' ' }, c);
                int x = Int32.Parse(l[0]);
                int y = Int32.Parse(l[1]);
                char di = l[2][0];
                foreach(char step in OrderSequence[i])
                {
                   
                    if(di == 'N')
                    {
                        if (step == 'L') di = 'W';
                        if (step == 'R') di = 'E';
                        if (step == 'M') y = y + 1;
                    }
                    else if(di == 'W')
                    {
                        if (step == 'L') di = 'S';
                        if (step == 'R') di = 'N';
                        if (step == 'M') x = x - 1;
                    }
                    else if(di == 'S')
                    {
                        if (step == 'L') di = 'E';
                        if (step == 'R') di = 'W';
                        if (step == 'M') y = y - 1;
                    }
                   else  if(di == 'E')
                    {
                        if (step == 'L') di = 'N';
                        if (step == 'R') di = 'S';
                        if (step == 'M') x = x + 1;
                    }
                }
                if((x>=0 && x<=upperX) && (y>=0 && y<=upperY))
                result[i] = x + " " + y + " " + di;
                else
                {
                    result[i] = "Invalid Move List";
                }
               
            }
            return result;
        }
    }
}
