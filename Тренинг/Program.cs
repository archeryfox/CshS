namespace Тренинг 
{

    class Program  
    {
        public static void Main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string coffee, milk, syrp;
            int price = 0;
            const int balance = 150;

            //sugar = Console.ReadLine();
          
            dynamic PricingCof(int rub, string s)
            { 
                switch (coffee)
                {
                    case "латте":
                        price = 10;
                        break;
                    case "капучино":
                        price = 15;
                        break;
                    case "эспрессо":
                        price = 20;
                        break;

                }
                return price;
            }

            Console.WriteLine("Выберите кофе: латте, капучино, эспрессо");
            coffee = Console.ReadLine();
            PricingCof(price, coffee);
             

            dynamic PricingMilk(int rub, string s)
            {
                switch(milk)
                {
                    case "д": price = price+10; break;
                    case "Д": goto case "д";
                    case "н": price = price; break;
                    case "Н": goto case "н";
                }
                return price;
            }

            Console.Write("Добавить молоко? д/н: ");
            milk = Console.ReadLine();
            PricingMilk(price, milk);
             

            dynamic PricingSugar(int rub, string s)
            {
                switch(s)
                {
                    case "нет": break;
                    case "": goto case "нет";
                    case " ": goto case "нет";
                    case "лесной орех": price = price + 10; break;
                    case "карамельный": price = price + 10; break;
                    case "ваниль": price = price + 10; break;
                    case "банановый": price = price + 10; break;

                }
                return price;
            }

            Console.WriteLine("Добавить сироп или нет: лесной орех, карамельный, ваниль, банановый?");
            syrp = Console.ReadLine();
            PricingSugar(price, syrp);
             

            if (balance >= price) 
            {
                Console.WriteLine($"Ваш заказ: {coffee} {syrp} {milk}");
                Console.WriteLine($"К оплате {price} руб.");
            }
            else
            {
                Console.WriteLine("Не достаточно денег на счёте!");
            }
            //            if purse > price then begin
            //writeln('Ваш заказ:', coffee, ' ', sugar, ' ', milk);
            //            writeln('С вас: ', price, '$')
            //end
            //else
            //                writeln('Не хватает денег');
            //            end.
        }
    }
}                   