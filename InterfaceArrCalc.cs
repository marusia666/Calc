using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface InterfaceArrCalc
    {
        //а [i] - массив, b -  аргумент
        void Put_A(ref int[] a); //сохраняем а

        void Clear_A(); //очищаем

        int[] Multiplication(int b); //умножение

        int[] Division(int b); //деление

        int[] Sum(int b); //сложение

        int[] Subtraction(int b); //вычитание

        int[] SqrtX(int b); //Корень степени X

        int[] Degree(int b); //Степень

        int[] Sqrt(); //Корень квадратный

        int[] Square(); //Квадрат

        int Factorial(ref int[] a, int j); //Фактриал

        int[] Log(int b); //Логарифм
    }
}
