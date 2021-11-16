using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAIPpractika
{
    class Hotel
    {
        public string HotelName;
        public int HotelStars;
        public string description;
        public Country location;
        public static List<Hotel> HotelsList = new List<Hotel>();
        public Hotel(string Name, int NumStar, string Description, Country Location)
        {
            HotelName = Name;
            HotelStars = NumStar;
            description = Description;
            location = Location;

        }

        public void Two(List<Hotel> HotelsList, List<Country> CountrysList)
        {
            Country selectedcountry = null;
            Hotel hotel = new Hotel();
            Console.Write("Введите название отеля: ");
            hotel.HotelName = Console.ReadLine();
            Console.Write("Введите кол-во звезд отеля: ");
            hotel.HotelStars = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите краткое описание отеля: ");
            hotel.description = Console.ReadLine();
            Console.Write("Введите страну, в которой расположен отель: ");
            string location = Console.ReadLine();
            foreach (Country c in CountrysList)
            {
                if (location == c.name)
                {
                    selectedcountry = c;
                    break;
                }
                if (selectedcountry == null)
                    return;
            }
            HotelsList.Add(new Hotel() { HotelName = hotel.HotelName, HotelStars = hotel.HotelStars, description = hotel.description, location = selectedcountry });

        }
        public void Three()
        {
            foreach (Hotel c in HotelsList)
            {
                Console.Write("Название отеля: " + c.HotelName + ", ");
                Console.Write(c.HotelStars + " звезды, ");
                Console.Write("Описание: " + c.description);
                Console.WriteLine("");
            }
        }
        public Hotel() { }


    }


    class Country
    {
        public string name;
        public string capital;
        public static List<Country> CountrysList = new List<Country>();
        public Country(string Name, string Stolitca)
        {
            name = Name;
            capital = Stolitca;
        }
        public void One()
        {
            Country country = new Country();
            Console.Write("Введите название страны: ");
            country.name = Console.ReadLine();
            Console.Write("Введите название столицы: ");
            country.capital = Console.ReadLine();
            CountrysList.Add(new Country() { name = country.name, capital = country.capital });
        }
        public void Four()
        {
            foreach (Country c in CountrysList)
            {
                Console.Write("Название страны: " + c.name + ", ");
                Console.Write("столица: " + c.capital + ".");
                Console.WriteLine("");
            }
        }
        public Country() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            Country country = new Country();
            int N = 0;
            while (N != 5)
            {
                Console.WriteLine("Выберите: ");
                Console.WriteLine("1) Добавить страну.");
                Console.WriteLine("2) Добавить отель.");
                Console.WriteLine("3) Показать все отели.");
                Console.WriteLine("4) Вывести все страны.");
                Console.WriteLine("5) Выйти из программы.");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    country.One();
                    continue;
                }
                if (n == 2)
                {
                    hotel.Two(Hotel.HotelsList, Country.CountrysList);
                    continue;
                }
                if (n == 3)
                {
                    hotel.Three();
                    continue;
                }
                if (n == 4)
                {
                    country.Four();
                    continue;
                }
                if (n == 5)
                {
                    Console.WriteLine("Досвидания!");
                    N = 5;
                    break;
                }
                else
                    Console.WriteLine("Выберите что - нибудь из предложенного списка: ");
                break;
            }
        }
    }
}