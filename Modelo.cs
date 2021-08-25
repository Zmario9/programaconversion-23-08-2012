using System;

namespace Modelo
{
    class Datos_monetarios
    {
        private double dolar_bolivar = 4000000;
        private double peso_bolivar = 1052;
        private double sol_bolivar = 996889;

        public double Dolar_bolivar
        {
            get { return dolar_bolivar; }
            set { dolar_bolivar = value; }
        }  

        public double Peso_bolivar
        {
            get { return peso_bolivar; }
            set { peso_bolivar = value; }
        }
        
        public double Sol_bolivar 
        {
            get { return sol_bolivar; }
            set { sol_bolivar = value; }
        }
    }
}