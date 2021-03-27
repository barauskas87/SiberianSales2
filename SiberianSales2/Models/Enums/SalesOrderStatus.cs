using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiberianSales2.Models.Enums
{
    public enum SalesOrderStatus : int
    {
        Enviada = 1,
        Faturada = 2,
        Recebida = 3,
        Comissionando = 4,
        Finalizado = 5,
        Cancelado = 6
    }

}
