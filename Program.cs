using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidarLetrasNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escriba la palabra que desea validar :");
            string PalabraAValidar = Console.ReadLine();//Solicitamos al usuario la parabra a evaluar

            string PatronLetras = @"\b[A-Z]\w*\b"; //Expresion Regular
            string PatronNumero = @"[0-9]"; //Expresion Regular

            Regex regexLetras = new Regex(PatronLetras);//Declaramos la variable como expresion  regular 
            Regex regexeNumero = new Regex(PatronNumero); //Declaramos la variable como expresion  regular 

            bool ValidoLestras = regexLetras.IsMatch(PalabraAValidar.ToString().ToUpper()); //Evaluamos la expresion regular con la palabra la pasamos a mayuscula para  mas presición y guardamos en una variable tipo Bool

            bool ValidoNumeros = regexeNumero.IsMatch(PalabraAValidar.ToString().ToUpper());//Evaluamos la expresion regular con la palabra y guardamos en una variable tipo Bool.

            string RespuestaLetras; //Variables para guardar la respuesta
            string RespuestaNumeros;

            if (ValidoLestras) { RespuestaLetras = "Si"; } else { RespuestaLetras = "No"; } //Evaluamos la respuesta
            if (ValidoNumeros) { RespuestaNumeros = "Si"; } else { RespuestaNumeros = "No"; } //Evaluamos la respuesta


             //Mostramos es resultado final.
            Console.WriteLine("La palabra :" + PalabraAValidar + " "+ RespuestaLetras + " es alfabetica" +  " y " + RespuestaNumeros + " es númerica."); 
            Console.ReadKey();


        }
             


    }
}
