using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int cantNotas=0;
       if(nota1 is null && nota2 is null && nota3 is null )
            {
                return 0;
            }
       if(nota1.HasValue &&(nota1.Value <0 || nota1.Value >10))
            { nota1 = null; } 
       if (nota2.HasValue && (nota2.Value < 0 || nota2.Value > 10))
                {
                nota2 = null;
                }
       if(nota3.HasValue && (nota3.Value < 0 || nota3.Value > 10))
            {
               nota3 = null;
            }
            if (nota1.HasValue) cantNotas++;
            if(nota2.HasValue) cantNotas++;
            if(nota3.HasValue) cantNotas++;

            int promedio = (nota1 ?? 0) + (nota2 ?? 0) + (nota3 ?? 0);

            return (double)promedio / cantNotas;

            
            }

        }
    }

