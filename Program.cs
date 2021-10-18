﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramandoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2004, 2, 10);
            DateTime fechaConHora = new DateTime(2021, 10, 18, 16, 40, 50);
            DateTime fechaHoy = new DateTime();
            fechaHoy = DateTime.Now;


            Console.WriteLine("Fecha en que entre a mi primer trabajo formal de Informática: " + fecha.ToString());
            Console.WriteLine(fecha.ToString("dd/MM/yyyy"));
            Console.WriteLine(fecha.ToString("dd/MM/yy"));
            Console.WriteLine("Fecha con Hora: " + fechaConHora.ToString("dd/MM/yyyy hh:mm:ss"));

            

            Console.WriteLine(fecha.AddDays(45).ToString("dd/MM/yyyy"));
            Console.WriteLine("Fecha de hoy: " + DateTime.Now);
            Console.WriteLine("La fecha de hoy más 45 días: " + fechaHoy.AddDays(45).ToString("dd/MM/yyyy"));
            Console.WriteLine(DateTime.Now.AddDays(45).ToString("dd/MM/yyyy"));

            

            Console.ReadLine();
        }

        

    }
}
