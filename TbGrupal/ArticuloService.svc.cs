using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TbGrupal
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ArticuloService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ArticuloService.svc o ArticuloService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ArticuloService : IArticuloService
    {

        static Articulo item1 = new Articulo("articulo 1",10.00,12345,500.00);
        static Articulo item2 = new Articulo("articulo 2",20.00,54321,100.00);
        static Articulo item3 = new Articulo("articulo 3",30.00,98765,300.00);
        static Articulo item4 = new Articulo("articulo 4",40.00,65494,900.00);

        Articulo[] items = { item1, item2, item3, item4 };
   
        public string GetDescriptionByCode(int codigo)
        {
            string description = "NO EXISTE";   

            for (int i = 0; i < items.Length; i++)
            {
                Articulo item = items[i];
                if (item.Code == codigo)
                {
                    description = item.Description;
                    break;
                }
            }
            return description;
        }

        public Articulo GetItemBySellMonth()
        {
            Articulo art = new Articulo();
            /*
            //con array
            double[] ventas = new double[items.Length];

            //con listado
            List<double> ventas2 = new List<double>();
            for (int i = 0; i < items.Length; i++)
            {
                ventas[i] = items[i].Sell;

                ventas2.Add(items[i].Sell);
            }*/

            //900.00
            var maxVal = items.Max(x=>x.Sell);
            art = items.First(x => x.Sell == maxVal);
            return art;
        }

        public double GetPriceByCode(int codigo)
        {
            double price = 0.00;

            for (int i = 0; i < items.Length; i++)
            {
                Articulo item = items[i];
                if (item.Code == codigo)
                {
                    price = item.Price;
                    break;
                }
            }
            return price;
        }
    }
}
