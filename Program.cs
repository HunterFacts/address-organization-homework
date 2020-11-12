using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressOrganization
{
    class Program
    {

        static List<Address> adresses = new List<Address>();

        static bool isRandom = true;
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.Clear();
            Console.WriteLine("Привет! Я твой помощник по нашим адресам.");
            Console.WriteLine("Введи нужную цифру из вариантов диалога.");
            Console.WriteLine("1. Посмотреть все адреса");
            Console.WriteLine("2. Создать свой адрес");
            if (isRandom)
            {
                Console.WriteLine("3. Заполни 3 адреса автоматически");
            }
            Console.Write("Введи цифру: ");

            try { 
                var key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        GetAllAdress();
                        break;

                    case 2:
                        createAddress();
                        break;

                    case 3:
                        if (isRandom)
                        {
                            threeAddressCreate();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Увы я такой команды не знаю, давай нажмем любую клавишу, вернемся и попробуем снова)))");
                            Console.ReadKey();
                            Start();
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Увы я такой команды не знаю, давай нажмем любую клавишу, вернемся и попробуем снова)))");
                        Console.ReadKey();
                        Start();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Чето сломалось, но это же не пугает бравых солдат, верно? Нажмем любую клавишу, вернемся и попробуем снова?");
                Console.ReadKey();
                Start();
            }
             
        }


        static void createAddress()
        {
            Console.Clear();
            Console.WriteLine("Отлично! Давай создам наш адрес, но помни, заполнять нужно с умом!");
            Console.WriteLine("");
            
            try
            {
                Address newAddress = new Address();
                Console.Write("Введи улицу: ");
                var street =  Console.ReadLine();
                newAddress.street = street;

                Console.Write("А теперь номер дома: ");
                var houseNumber = Convert.ToInt32(Console.ReadLine());
                newAddress.houseNumber = houseNumber;

                Console.Write("А теперь корпус, если есть: ");
                var housing = Console.ReadLine();
                newAddress.housing = housing;

                Console.Write("Населенный пункт: ");
                var settlement = Console.ReadLine();
                newAddress.settlement = settlement;

                Console.Write("Район: ");
                var district = Console.ReadLine();
                newAddress.district = district;

                Console.Write("Край: ");
                var republic = Console.ReadLine();
                newAddress.republic = republic;

                Console.Write("Страну: ");
                var country = Console.ReadLine();
                newAddress.country = country;

                Console.Write("И индекс: ");
                var indexAddress = Convert.ToInt32(Console.ReadLine());
                newAddress.indexAddress = indexAddress;

                adresses.Add(newAddress);
                Console.WriteLine("Отлично, адрес создан!");
                Console.ReadKey();
                Start();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Как-то ты неправильно вводил данные. Охх, придеться все заново, извини.");
                Console.WriteLine("Вот что случилось: ");
                Console.Write(ex.Message);
                Console.ReadKey();
                Start();
            }
        }

        static void GetAllAdress()
        {
            Console.Clear();
            if (adresses.Count > 0)
            {
                int integer = 1;
                Console.WriteLine("Вот все адреса");
                Console.WriteLine("");
                foreach (var address in adresses)
                {
                    Console.WriteLine("(" + integer.ToString() + ") " + address.AddressBuild
                        );
                    integer++;
                }
                Console.ReadKey();
                Start();
            }
            else
            {
                Console.WriteLine("Увы, на данный момент адресов в системе нет. Нажми любую клавишу, чтобы вернуться к спискам выбора");
                Console.ReadKey();
                Start();
            }
        }

        static void threeAddressCreate()
        {
            Console.Clear();
            Address newAddress = new Address(
                "Попова",
                23,
                "",
                "Пермь",
                "Ленинский",
                "Пермский",
                "Россия",
                603320
                );
            adresses.Add(newAddress);

            newAddress = new Address(
                "Стахановская",
                32,
                "2",
                "Пермь",
                "Индустриальный",
                "Пермский",
                "Россия",
                604320
                );
            adresses.Add(newAddress);

            newAddress = new Address(
                "Куликова",
                23,
                "",
                "Москва",
                "Ленинский",
                "Пермский",
                "Россия",
                403420
                );
            adresses.Add(newAddress);

            isRandom = false;
            Console.WriteLine("Отлично, адреса созданы!");
            Console.ReadKey();
            Start();
        }
    }
}
