using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            first();
            second();
            third();
        }
        public static void first()
        {
            Console.WriteLine("Введiть кiлькiсть елементiв списку");
            int kolvo = Convert.ToInt32(Console.ReadLine());
            var listt = new List<string>();
            for (int i = 0; i < kolvo; i++)
            {
                Console.WriteLine("Введiть елемент списку");
                listt.Add(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Список");
            foreach (var element in listt)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < kolvo; i++)
            {
                string k = listt[i];
                for (int j = 0; j < kolvo; j++)
                {
                    if (k == listt[j])
                    {
                        count++;
                    }
                }
            }
            if (count > kolvo)
            {
                Console.WriteLine("Не всi елементи списку є унiкальними");
            }
            else
            {
                Console.WriteLine("Всi елементи списку є унiкальними");
            }
        }
        public static Dictionary<int, string> Dic(int i)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Console.WriteLine("Введiть слово: \n");
            string s;
            for (int j = 0; j < i; j++)
            {
                Console.Write("{0} --> ", j);
                s = Console.ReadLine();
                dic.Add(j, s);
            }
            return dic;
        }
        private static void second()
        {
            Console.WriteLine("Введiть кiлькiсть слiв, якi необхiдно записати в словник");
            int i = int.Parse(Console.ReadLine());
            var dic = new Dictionary<int, string>();
            dic = Dic(i);
            var values = dic.Values;
            List<string> list = new List<string>();
            foreach (string item in values)
            {
                list.Add(item);
            }
            list.Sort();
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void third()
        {
            Console.WriteLine("Введiть кiлькiсть чисел");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введiть число");
                nums[i] = int.Parse(Console.ReadLine());
            }

            int firstp = nums.FirstOrDefault(num => num > 0);
            int lastn = nums.LastOrDefault(num => num < 0);

            if (firstp == 0)
            {
                Console.WriteLine($"Додатнiх чисел немає. Останнє вiд'ємне число: {lastn}");
            }
            else if (lastn == 0) 
            {
                Console.WriteLine($"Перше додатнє число: {firstp}. Вiд'ємних чисел немає");
            }
            else
            Console.WriteLine($"Перше додатнє число: {firstp}. Останнє вiд'ємне число: {lastn}");
        }
    }
}
