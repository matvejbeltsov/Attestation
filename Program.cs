using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using Microsoft.Win32.SafeHandles;

namespace Attestation
{
    internal class Program
    {
        public static string[] inizialisation_array(int length_of_array){
            string[] array = new string[length_of_array];
            Console.WriteLine("Введите слова, которые вы будете хранить в данном массиве");
            for (int i = 0; i < array.Length; i++){
                array[i] = Console.ReadLine();
            }
            return array;

        }

        public static void print_array(string[] array){
            Console.Write("[");
             for (int i = 0; i < array.Length - 1; i++){
                Console.Write($"\"{array[i]}\", ");
            }
            Console.Write($"\"{array[array.Length - 1]}\"]");
        }

        
        
       
        static void Main(string[] args)
        {
            Console.Write("Укажите длинну массива: ");
            int length_of_array = Convert.ToInt32(Console.ReadLine());
            string[] array = inizialisation_array(length_of_array);
            print_array(array);
        }
    }
}
