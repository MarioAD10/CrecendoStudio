using SoftwareGestionNomina.DAL.Repositories.Maestros;
using SoftwareGestionNomina.Entities.Entities.Maestros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareGestionNomina.BLL.Services.Maestros
{

    // Capa de negocios de los maestros
    public class B_Maestros
    {
        D_Maestros objDato = new D_Maestros();

        public List<E_Maestros> ListarMaestro(string busqueda)
        {
            return objDato.ListarMaestro(busqueda);
        }

        public void InsertandoMaestro(E_Maestros m)
        {
            objDato.InsertarMaestro(m);
        }

        public void ModificandoMaestro(E_Maestros m)
        {
            objDato.ModificarMaestro(m);
        }

        public void EliminandoMaestro(E_Maestros m)
        {
            objDato.EliminarMaestro(m);
        }
    }
}
