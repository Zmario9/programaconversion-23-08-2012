using System;
using Modelo;
using Vista;

namespace Controlador

{
  class procesocontrolador 
  {
     Datos_monetarios dm = new Datos_monetarios();

        public double traer_de_bolivar_a_dolar(double bolivar)
        {
          return bolivar / dm.Dolar_bolivar;
        }

        public double traer_de_dolar_a_bolivar(double bolivar)
        {
          return bolivar * dm.Dolar_bolivar;
        }
        
        public double traer_de_bolivar_a_peso(double bolivar)
        {
          return bolivar / dm.Peso_bolivar;
        }

        public double traer_de_peso_a_bolivar(double bolivar){
          return bolivar * dm.Peso_bolivar;
        }

        public double traer_de_bolivar_a_sol(double bolivar){
          return bolivar / dm.Sol_bolivar;
        }

        public double traer_de_sol_a_bolivar(double bolivar){
          return bolivar * dm.Sol_bolivar;
        }
  }
}