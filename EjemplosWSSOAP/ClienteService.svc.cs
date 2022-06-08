using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EjemplosWSSOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ClienteService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ClienteService.svc o ClienteService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ClienteService : IClienteService
    {
        public string ValidarDNI(string dni)
        {
            throw new NotImplementedException();
        }

        public string ValidarCodigo(int codigo)
        {
            int[] codigos = { 12345, 54321, 56781, 98765 };
            string mensaje = "Código NO ENCONTRADO";
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigo == codigos[i])
                {
                    mensaje = "Código correcto!";
                }
            }
            return mensaje;
        }

    }
}
