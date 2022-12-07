using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zina
{
    class Program
    {
        public static int Jerk_off_the_user( int edge)
        {
         
            int num_user = int.Parse(Console.ReadLine());
            if (num_user <= edge)
            {
                return num_user;
            }
            else
            {
                Console.WriteLine("Введите число не превышающее количество людей в очереди ");
                return Jerk_off_the_user(edge);
            }
        }
        public static void Reserf(LinkedList<Resident> Koth)
        {
            foreach(Resident i in Koth)
            {
                Console.WriteLine($"{ i.name}\n{i.num_passport}\n{i.mind}\n{i.problem}\n{i.temperament}");
            }
        }
        public enum Problen_heating
        {
            Лопнули_баттарии = 1,
            Батареи_не_граются = 2,
            Не_изменяется_температура_на_баттареях = 3,
            Подключение_отопления = 4
        }

        public enum Problem_payment
        {
            Необходимо_узнать_номер_лицевого_счета = 5,
            Не_работает_оплата_онлайн = 6,
            Платеж_не_проходит = 7
        }

        public enum Problem_all
        {
            Получить_справку = 8,
            Записаться_в_очередь_на_вызов_сантехника = 9,
            Встать_на_учет = 10
        }

        public struct Resident
        {
            public string name;
            public int num_passport;
            public string problem;
            public int temperament;
            public int mind;
        }

        public static void Zina(Random x,  List<Resident> village_people,  LinkedList<Resident> queue_1,  LinkedList<Resident> queue_2, LinkedList<Resident> queue_3)
        {
            LinkedList<Resident> copy_queue = new LinkedList<Resident>();
            int a;
            int overtaking;
            int num = village_people.Count();
            for (int v = 0; v < num; v++)
            {// тупой, но не агрессивный
                if (village_people[village_people.Count() - 1].mind == 0 && village_people[village_people.Count() - 1].temperament < 5)
                {
                    a = x.Next(1, 4);
                    switch (a)
                    {
                        case 1:
                            {
                                queue_1.AddLast(village_people[village_people.Count() - 1]);
                                village_people.RemoveAt(village_people.Count() - 1);
                                break;
                            }
                        case 2:
                            {
                                queue_2.AddLast(village_people[village_people.Count() - 1]);
                                village_people.RemoveAt(village_people.Count() - 1);
                                break;
                            }
                        case 3:
                            {
                                queue_3.AddLast(village_people[village_people.Count() - 1]);
                                village_people.RemoveAt(village_people.Count() - 1);
                                break;
                            }
                    }
                }//тупой и аграссивный
                else if (village_people[village_people.Count() - 1].mind == 0 && village_people[village_people.Count() - 1].temperament >= 5)
                {
                    a = x.Next(1, 4);
                    switch (a)
                    {
                        case 1:
                            {
                                Console.WriteLine($"В очереди стоит {queue_1.Count()} лиц, скольких обгонит {village_people[village_people.Count() - 1].name}");
                                overtaking = Jerk_off_the_user(queue_1.Count());
                                foreach (Resident i in queue_1)
                                {
                                    copy_queue.AddLast(i);
                                }
                                for (int i = 0; i < overtaking; i++)
                                {
                                    copy_queue.RemoveLast();
                                }
                                queue_1.AddLast(village_people[village_people.Count() - 1]);
                                village_people.RemoveAt(village_people.Count() - 1);
                                copy_queue.Clear();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine($"В очереди стоит {queue_2.Count()} лиц, скольких обгонит {village_people[village_people.Count() - 1].name}");
                                overtaking = Jerk_off_the_user(queue_2.Count());
                                foreach (Resident i in queue_2)
                                {
                                    copy_queue.AddLast(i);
                                }
                                for (int i = 0; i < overtaking; i++)
                                {
                                    copy_queue.RemoveLast();
                                }
                                queue_2.AddLast( village_people[village_people.Count() - 1]);
                                village_people.RemoveAt(village_people.Count() - 1);
                                copy_queue.Clear();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine($"В очереди стоит {queue_3.Count()} лиц, скольких обгонит {village_people[village_people.Count() - 1].name}");
                                overtaking = Jerk_off_the_user(queue_3.Count());
                                foreach (Resident i in queue_3)
                                {
                                    copy_queue.AddLast(i);
                                }
                                for (int i = 0; i < overtaking; i++)
                                {
                                    copy_queue.RemoveLast();
                                }
                                queue_3.AddLast( village_people[village_people.Count() - 1]);
                                village_people.RemoveAt(village_people.Count() - 1);
                                copy_queue.Clear();
                                break;
                            }
                    }
                }
                else if (village_people[village_people.Count() - 1].mind == 1 && village_people[village_people.Count() - 1].temperament >= 5)
                {//если умный и агрессивный
                    if (Enum.IsDefined(typeof(Problen_heating), village_people[village_people.Count() - 1].problem))
                    {
                        Console.WriteLine($"В очереди стоит {queue_1.Count()} лиц, скольких обгонит {village_people[village_people.Count() - 1].name}");
                        overtaking = Jerk_off_the_user(queue_1.Count());
                        foreach (Resident i in queue_1)
                        {
                            copy_queue.AddLast(i);
                        }
                        for (int i = 0; i < overtaking; i++)
                        {
                            copy_queue.RemoveLast();
                        }
                        queue_1.AddLast( village_people[village_people.Count() - 1]);
                        village_people.RemoveAt(village_people.Count() - 1);
                        copy_queue.Clear();
                    }
                    else if (Enum.IsDefined(typeof(Problem_payment), village_people[village_people.Count() - 1].problem))
                    {
                        Console.WriteLine($"В очереди стоит {queue_2.Count()} лиц, скольких обгонит {village_people[village_people.Count() - 1].name}");
                        overtaking = Jerk_off_the_user(queue_2.Count());
                        foreach (Resident i in queue_2)
                        {
                            copy_queue.AddLast(i);
                        }
                        for (int i = 0; i < overtaking; i++)
                        {
                            copy_queue.RemoveLast();
                        }
                        queue_2.AddLast( village_people[village_people.Count() - 1]);
                        village_people.RemoveAt(village_people.Count() - 1);
                        copy_queue.Clear();
                    }
                    else if (Enum.IsDefined(typeof(Problem_all), village_people[village_people.Count() - 1].problem))
                    {
                        Console.WriteLine($"В очереди стоит {queue_3.Count()} лиц, скольких обгонит {village_people[village_people.Count() - 1].name}");
                        overtaking = Jerk_off_the_user(queue_3.Count());
                        foreach (Resident i in queue_3)
                        {
                            copy_queue.AddLast(i);
                        }
                        for (int i = 0; i < overtaking; i++)
                        {
                            copy_queue.RemoveLast();
                        }
                        queue_3.AddLast( village_people[village_people.Count() - 1]);
                        village_people.RemoveAt(village_people.Count() - 1);
                        copy_queue.Clear();
                    }
                }
                else if (village_people[village_people.Count() - 1].mind == 1 && village_people[village_people.Count() - 1].temperament < 5)
                {//если умный и паинька
                    if (Enum.IsDefined(typeof(Problen_heating), village_people[village_people.Count() - 1].problem))
                    {
                        queue_1.AddLast(village_people[village_people.Count() - 1]);
                        village_people.RemoveAt(village_people.Count() - 1);
                    }
                    else if (Enum.IsDefined(typeof(Problem_payment), village_people[village_people.Count() - 1].problem))
                    {
                        queue_2.AddLast(village_people[village_people.Count() - 1]);
                        village_people.RemoveAt(village_people.Count() - 1);
                    }
                    else if (Enum.IsDefined(typeof(Problem_all), village_people[village_people.Count() - 1].problem))
                    {
                        queue_3.AddLast(village_people[village_people.Count() - 1]);
                        village_people.RemoveAt(village_people.Count() - 1);
                    }
                }
            }
        }
        public static string Problem_at_metod(int k, Random v)
        {
            if (k < 5)
            {
                return Enum.GetName(typeof(Problen_heating), v.Next(1, 5));
            }
            else if (k >= 5 && k <= 7)
            {
                return Enum.GetName(typeof(Problem_payment), v.Next(5, 8));
            }
            else if (k > 7)
            {
                return Enum.GetName(typeof(Problem_all), v.Next(8, 11));
            }
            return Enum.GetName(typeof(Problem_all), 10);
        }
        static void Main(string[] args)
        {
            Random x = new Random();
            LinkedList<Resident> queue_1 = new LinkedList<Resident>();
            LinkedList<Resident> queue_2 = new LinkedList<Resident>();
            LinkedList<Resident> queue_3 = new LinkedList<Resident>();
            string[] name_of_resident = new string[] { "Олег", "Элина", "Зинаида", "Татьяна", "Ольга", "Эльвира", "Андрей", "Абдулахман-ибн", "Алина", "Василий", "Григорий", "Махмед", "Максим", "Иосиф", "Ярослав", "София", "Елена", "Ева", "Анна", "Михаил" };
            List<Resident> House_village = new List<Resident>();
            for (int i = 0; i < 10; i++)
            {
                Resident people_house = new Resident();
                people_house.name = name_of_resident[x.Next(0, name_of_resident.Count())];
                people_house.num_passport = x.Next(100000, 1000000);
                people_house.temperament = x.Next(0, 11);
                people_house.problem = Problem_at_metod(x.Next(1, 11), x);
                people_house.mind = x.Next(0, 2);
                House_village.Add(people_house);
            }
            House_village.Reverse();
            Zina(x, House_village, queue_1, queue_2, queue_3);
            Reserf(queue_1);
            Console.ReadKey();
        }
    }
}
