using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface InterfaceCalc
    {
        //а - первый аргумент, b - второй аргумент
        void Put_A(double a); //сохраняем а

        void Clear_A(); //очищаем

        double Multiplication(double b); //умножение

        double Division(double b); //деление

        double Sum(double b); //сложение

        double Subtraction(double b); //вычитание

        double SqrtX(double b); //Корень степени X

        double Degree(double b); //Степень

        double Sqrt(); //Корень квадратный

        double Square(); //Квадрат

        double Factorial(); //Фактриал

        double Percent(); //Процент

        double Log(double b); //Логарифм

        double ShowHist();

        void RemHist(double b);
    }
}
