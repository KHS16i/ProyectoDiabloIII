//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoDiabloIII.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salud
    {

        private int _IdSalud, _IdPersonaje;
        private decimal _Porcentaje;

    
        public virtual Personaje Personaje { get; set; }
        public int IdSalud { get => _IdSalud; set => _IdSalud = value; }
        public int IdPersonaje { get => _IdPersonaje; set => _IdPersonaje = value; }
        public decimal Porcentaje { get => _Porcentaje; set => _Porcentaje = value; }
    }
}
