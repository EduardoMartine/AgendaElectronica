using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class N_Agenda
    {
        D_Agenda objDato = new D_Agenda();
        public List<E_Agenda> Lista(string buscar)
        {
            return objDato.D_Lista(buscar);
        }
        public void Insertando(E_Agenda categoria) 
        { 
            objDato.Insertar(categoria);
        }
        public void Modificando(E_Agenda categoria)
        {
            objDato.Modificar(categoria);
        }
        public void EliminandoRegistro(E_Agenda categoria) 
        { 
            objDato.Eliminarregistro(categoria);
        }
      
    }
}
