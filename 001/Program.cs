Console.WriteLine("Задание N1");
Console.WriteLine("***********");
Console.Write("Введите Ваше имя: ");
string n = Console.ReadLine();
Console.Write("Введите Вашу фамилию: ");
string f = Console.ReadLine();
Console.Write("Введите Ваш возраст: ");
string v = Console.ReadLine();
Console.Write("Введите Ваш рост: ");
string r = Console.ReadLine();
Console.Write("Введите Ваш вес: ");
string ves = Console.ReadLine();

Console.WriteLine("Здравствуйте, " + n + " " + f + ". Ваш возраст " + v + ", рост " + r + ", и вес " + ves);
Console.WriteLine("Здравствуйте, {0} {1}. Ваш возраст {2}, рост {3}, и вес {4}", n, f, v, r, ves);
Console.WriteLine($"Здравствуйте, {n} {f}. Ваш возраст {v}, рост {r}, и вес {ves}");
Console.ReadKey();