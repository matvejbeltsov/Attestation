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

        public static string[] solving_the_task(string[] array){
            int count = 0;
            for (int i = 0; i < array.Length; i++){
                if(array[i].Length <= 3){
                    count++;
                }
            }
            string[] new_array = new string[count];
            int index = 0;
            for(int i = 0; i < array.Length; i++){
                if(array[i].Length <= 3){
                    new_array[index] = array[i];
                    index++;
                }
            }
            return new_array;
        }

        
        
       
        static void Main(string[] args)
        {
            Console.Write("Укажите длинну массива: ");
            int length_of_array = Convert.ToInt32(Console.ReadLine());
            string[] array = inizialisation_array(length_of_array);
            Console.WriteLine("Изначальный массив: ");
            print_array(array);
            string[] new_array = solving_the_task(array);
            Console.WriteLine("\nРезультат выполнения программы: ");
            print_array(new_array);
        }
    }
}
