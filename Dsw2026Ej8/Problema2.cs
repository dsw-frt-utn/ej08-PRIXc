using System;
using System.Collections.Generic;
using System.Text;


namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal totalValue;
            if (quantity <= 0)
            {
               totalValue = 0;
                
            }
            else
            {
                totalValue = quantity * unitPrice;
            }
             


            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = totalValue
            };

            return $"{resumen.Code}-{ resumen.Description}-{resumen.Total}";


        }
    }
}
