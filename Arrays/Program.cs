using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();  //создаем объект класса Array
            //int[] tmp = array.GetRandomArray(10, -100, 100); //вызываем метод объекта write и передаем в этот метод параметры. Получаем массив и присваеиваем его переменной tmp

            //for (int i = 0; i < tmp.Length; i++)
            //{
            //    Console.WriteLine(tmp[i]);
            //}

            //int[] numbers = new int[6] { 26, 652, -66, 0, 5, -5 };//создание массива из 6 элементов
            //int sum=array.CalculateSumOfElementsOddIndex(numbers);
            //Console.WriteLine(sum);

            //int minValue = array.FindMinElement(numbers);
            //Console.WriteLine(minValue);

            //int[] massive = array.GetRandomArray(10, -100, 100);
            //Console.WriteLine(massive);
            //int index = array.FindIndexMinElement(massive);
            //Console.WriteLine(index);

            int[] massiveSecond = array.GetRandomArray(10, -100, 100);
            array.WriteInConsole(massiveSecond);
            var reverseArray  = array.Reverse(massiveSecond);
            array.WriteInConsole(reverseArray);


        }
    }
}
