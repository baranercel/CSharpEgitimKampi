 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri
            // syntax = DeğişkenTürü [] diziAdı = new DeğiskenTürü[ElemanSayısı];

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";


            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[4] = 748;
            //// tam sayı formatında olan dizinin default değeri 0 dır

            //string[]cities = {"Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);



            #endregion
            #region Dizideki Tüm Elemanları Listeleme

            //string[]colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil","Turuncu","Pembe" };
            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96,75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %3== 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[]symbols = { '!', '?', '*', '&', '%', '$', '#', '@' };
            //for (int i = 0; i < symbols.Length; i++) { 
            //    Console.WriteLine(symbols[i]);
            //}
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = {"ali","ahmet","mehmet","ayşe","fatma","zeynep" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 4, 2365, 96, 75, 125, 635, 488, 522, 7456,85 , 1120 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) {
            //Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 4, 2365, 96, 75, 125, 635, 488, 522, 7456, 85, 1120 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++) { 
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion
            #region Dizi Metotlar

            //string[] customers = {"ali","buse","aysegül","merve","çınar","kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 4, 2365, 96, 75, 125, 635, 488, 522, 7456, 85, 1120 };
            //Console.WriteLine("Dizinin en büyük elemanı "+ numbers.Max()+ " Dizinin en küçük elemanı "+numbers.Min());



            #endregion
            #region Kullanıcıdan Değer Alma

            //string[]cities = new string[5];
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("Girdiğiniz Şehirler: ");
            //for (int i = 0; i < cities.Length; i++) 
            //{ 
            //    Console.WriteLine(cities[i]);
            //}
            #endregion
            Console.Read();
        }
    }
}
