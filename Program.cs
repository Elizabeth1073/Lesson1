﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lessonHW
{
    //Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.

    struct Complex
    {
        public double re;
        public double im;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public static Complex Substract(Complex q, Complex w)
        {
            return new Complex(q.re - w.re, q.im - q.re);
        }

        public static Complex Mult(Complex q, Complex w)
        {
            return new Complex(q.re * w.re, q.im * w.im);
        }

        public void PrintS()
        {
            Console.WriteLine($"{re} - {im}i");
        }
        public void PrintM()
        {
            Console.WriteLine($"{re} * {im}i");
        }
        //public void Create()
        //{
        //    Complex z1 = new Complex(re: 123, im: 45);
        //    Complex z2 = new Complex(re: 3, im: 67);
        //    Complex z3 = Complex.Substract(z1, z2);
        //}

    }

    class Program
    {

        static void Main(string[] args)
        {
            Complex z1 = new Complex(re: 123, im: 45);
            Complex z2 = new Complex(re: 3, im: 67);
            Complex z3 = new Complex();

            Console.WriteLine("Добро пожаловать в калькулятор вещественных чисел! Для того, чтобы начать выберите операцию: \nвычитание\nумножение");
            string user = Console.ReadLine();
            switch (user)
            {
                case "вычитание":
                    z3 = Complex.Substract(z1, z2);
                    z3.PrintS();
                    break;
                case "умножение":
                    z3 = Complex.Mult(z1, z2);
                    z3.PrintM();
                    break;
                default:
                    Console.WriteLine("Ошибка, введены некорректные данные");
                    break;
            }



            Console.ReadLine();
        }
    }
    
}
