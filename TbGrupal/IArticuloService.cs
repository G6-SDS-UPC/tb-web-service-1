using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TbGrupal
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IArticuloService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IArticuloService
    {
        [OperationContract]
        string GetDescriptionByCode(int codigo);

        [OperationContract]
        double GetPriceByCode(int codigo);

        [OperationContract]
        Articulo GetItemBySellMonth();
    }
}
