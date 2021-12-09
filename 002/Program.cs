Console.WriteLine("Давайте посчитаем ИМТ вашего тела.");
Console.Write("Какой у Вас вес в килограммах? ");
int v= Convert.ToInt32(Console.ReadLine());
Console.Write("Какой у Вас рост в сантиметрах? ");
float r= Convert.ToInt32(Console.ReadLine())/100;
Console.WriteLine($"Ваш ИМТ тела {v/(r*r)}");
Console.ReadKey();
