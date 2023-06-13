using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Nota
    {
        private CD_Nota objcd_nota = new CD_Nota();
        public List<Nota> Listar()
        {
            return objcd_nota.Listar();
        }
        public static void Registrar(Nota obj)
        {
            if (obj.IdNota == 0)
            {
                CD_Nota.Registrar(obj);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static void Eliminar(Nota obj)
        {
            CD_Nota.Eliminar(obj);
        }
    }
}
