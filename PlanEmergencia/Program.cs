﻿using System;
using Libreria_de_clases;

namespace PlanEmergencia
{
    class Program
    {
        static void Main()
        {
			int[,,] i = new int[3, 2, 9]  {
                                            {
                                                {0,2,6,0,1,6,0,6,5},
                                                {0,4,5,0,6,6,5,3,5}
                                            },
                                            {
                                                {0,3,3,0,7,5,0,4,1},
                                                {0,6,4,0,3,6,7,3,1}
                                            },
                                            {
                                                {0,5,5,0,6,5,0,7,4},
                                                {0,7,6,0,5,7,7,1,4}
                                            }

                                        };
            Edificio e = new Edificio(i);
            Console.WriteLine(e.ObtenerDatos());
        }
    }
}
