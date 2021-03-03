using System;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;



//Тема: Кортежи


//Задание №1
//Как вам уже известно – кортежи позволяют сгруппировать разнотипные данные.
//Напишите метод класса, который группирует данные из различных источников в один пакет и возвращает его.
//Напишите метод класса, который эти данные может принять и обработать. Организуйте своеобразную передачу пакетных данных между методами.

class Korteg
{


   
    int int_size;
    int [] int_arr;

    int double_size;
    double[] double_arr;

    int str_size;
    string[] str_arr;

    public Korteg()
    {

        int_size = 1;
        int_arr = new int[int_size];

        double_size = 1;
        double_arr = new double[double_size];

        str_size = 1;
        str_arr = new string[str_size];
    }

    //перегруженные методы вносса данных с помощью массивов
     public int []  add_value(int number)
    {
        int[] new_arr=new int[int_size];

        for (int i = 0,j=0; i < int_arr.GetLength(0); i++,j++)
        {
            new_arr[j] = int_arr[i];
        }
        if (int_size==1)
        {
            int_arr[0] = number;
        }
        else
        {
            new_arr[int_size - 1] = number;
            int_arr = new_arr;
        }
       
        int_size++;
        return this.int_arr;
    }
    //перегруженные методы вносса данных с помощью массивов
    public double[] add_value(double number)
    {
        double[] new_arr = new double[double_size];

        for (int i = 0, j = 0; i < double_arr.GetLength(0); i++, j++)
        {
            new_arr[j] = double_arr[i];
        }
        if (double_size == 1)
        {
            double_arr[0] = number;
        }
        else
        {
            new_arr[double_size - 1] = number;
            double_arr = new_arr;
        }

        double_size++;
        return double_arr;
    }
    //перегруженные методы вносса данных с помощью массивов
    public string[] add_value(string text)
    {
        string[] new_arr = new string[str_size];

        for (int i = 0, j = 0; i < str_arr.GetLength(0); i++, j++)
        {
            new_arr[j] = str_arr[i];
        }
        if (str_size == 1)
        {
            str_arr[0] = text;
        }
        else
        {
            new_arr[str_size - 1] = text;
            str_arr = new_arr;
        }

        str_size++;
        return str_arr;
    }


    //групируем данные в кортеж и возвращаем его как значение
    public ( int[],double[],string[]) Group_korteg(int[]arr_i,double[]arr_d,string[]arr_s)
    {

        var group_kort = (arr_i,arr_d,arr_s);

        return group_kort;

    }

 //метод вывода значения кортежа
   public static void Print_korteg((int[] ,double[],string[])var_korteg)
    {

        Console.WriteLine("Значения кортежа Item1 массив интов :");
        for (int i = 0; i < var_korteg.Item1.GetLength(0); i++)
        {
            Console.Write(var_korteg.Item1[i]+"|");
        }
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Значения кортежа Item2 массив типа дабл :");
        for (int i = 0; i < var_korteg.Item1.GetLength(0); i++)
        {
            Console.Write(var_korteg.Item2[i] + "|");
        }
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Значения кортежа Item3 массив типа строки :");
        for (int i = 0; i < var_korteg.Item1.GetLength(0); i++)
        {
            Console.Write(var_korteg.Item3[i] + "|");
        }
        Console.WriteLine();
    }

}

namespace D_Kortegi_21._09._2020
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Korteg test=new Korteg();
            //массивы для дальнейшей передачи в метод который сгрупирует их в кортеж 
            int [] array_int;
            double[] array_double;
            string[] array_str;

            //присваиваем значения массивам через методы
          array_int=  test.add_value(1111);
           array_double= test.add_value(9.9);
            array_str=test.add_value("text");
      
            array_int = test.add_value(2222);
            array_double=test.add_value(10.1);
            array_str=test.add_value("text2");

            //пердаем массивы методу класса для групирования в кортеж 
            var New_korteg =test.Group_korteg(array_int,array_double,array_str);

            //разбираем кортеж с помощью метода класса
            Korteg.Print_korteg(New_korteg);

        }
    }
}
