using System.IO.Compression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entidades;
using System.Linq.Expressions;

namespace Core.Especificaciones
{
    public class LugaresConPaisCategoriaEspecificacion : EspecificacionBase<Lugar>
    {
        public LugaresConPaisCategoriaEspecificacion()
        {
            AgregarInclude(x=>x.Pais);
            AgregarInclude(x=>x.Categoria);
        }

        public LugaresConPaisCategoriaEspecificacion(int id) : base(x=> x.Id == id)
        {
            AgregarInclude(x=>x.Pais);
            AgregarInclude(x=>x.Categoria);
        }
    }
}