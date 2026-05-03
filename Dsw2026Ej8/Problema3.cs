using System;
using System.Collections.Generic;
using System.Text;
using Dsw2026ej6.Domain;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product producto)
        {
            int copia = originalValue;
            copia++;

            Product productoCopia = producto;
            productoCopia.Update("nueva descripcion");

            return $"{originalValue}-{productoCopia}-{productoCopia.GetDescription}"
        }
    }
}
