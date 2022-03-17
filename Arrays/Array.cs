using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class Array
    {
        public int[] GetRandomArray(int lenght, int min = -100, int max = 100)
        {
            if (lenght < 0)
            {
                throw new Exception("Lenght > 0"); //создаем объект класса исключение(Exception) и пробрасываем это исключение
            }

            int[] arrayRandom = new int[lenght];//создаем объект класса массив заданной длины
            Random random = new Random(); //создаем объект класса
            for (int i = 0; i < lenght; i++) //перебираем массив
            {
                int randomNumber = random.Next(min, max); //возвращает рандомное значение
                arrayRandom[i] = randomNumber; //обращаемся к каждому элементу массива и присваиваем ему рандомное значение
            }
            return arrayRandom; //возвращаем заполненный массив
        }

        //26, 652, -3, 0, 5
        public int FindMinElement(int[] array) //метод работает с массивом
        {
            int minElement=array[0];
            for (int i=0; i<array.Length; i++)
            {
                if (minElement>array[i])
                {
                    minElement = array[i];
                }
            }
            return minElement;
        }

        public int FindMaxElement(int[] array) //МАксимальный
        {
            int maxElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (maxElement < array[i])
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }

        public int FindIndexMinElement(int[] array) //Найти индекс минимального элемента массива
        {
            int MinElement = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (MinElement > array[i])
                {
                    MinElement = array[i];
                    index = i;
                }
            }
            return index;
        }

        public int FindIndexMaxElement(int[] array) //Найти индекс максимального элемента массива
        {
            int MaxElement = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (MaxElement < array[i])
                {
                    MaxElement = array[i];
                    index = i;
                }
            }
            return index;
        }


        //Посчитать сумму элементов массива с нечетными индексами

        public int CalculateSumOfElementsOddIndex(int[] array)
        {
            int sumOfElements = 0;
            for(int i=1; i<array.Length; i+=2)
            {
                sumOfElements += array[i];
            }
            return sumOfElements;
        }

        //Сделать реверс массива (массив в обратном направлении)
        public int [] Reverse(int[] array)
        {
            int index = 0;
            int[] massiveReverse=new int [array.Length];
            for(int i=array.Length-1; i<array.Length; i--)
            {
                massiveReverse [index]= array[i];
                index++;
            }
            return massiveReverse;
        }

        //Метод для вывода массива в консоль
        public void WriteInConsole(int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //Посчитать количество нечетных элементов массива
        public int CalculateNumberOfOddElements(int[] array)
        {
            int countOfOddElements=0;
            for(int i=0; i<array.Length; i++)
            {
                if (array[i]%2==1)
                {
                    countOfOddElements++;
                }
            }
            return countOfOddElements;
        }
        //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        public int [] SwapHalves(int[] array)
        {

        }
    }
}
