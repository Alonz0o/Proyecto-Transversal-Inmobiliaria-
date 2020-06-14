using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Transversal_Inmobiliaria_.Models
{
     
    public interface IRepositorioPago : IRepositorio<Pago>
	{

        IList<Pago> BuscarPorAlquileres(int PagoId);
    }
}
