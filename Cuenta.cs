using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Cuenta
    {
        public string titular;
        private int cantidad;

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        
        public string getTitular(string titular)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titular: {titular}");
            return sb.ToString();
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public string mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titular: {titular}");
            sb.AppendLine($"Cantidad: {cantidad}");
            return sb.ToString(); 
        }

        public int ingresar(int monto)
        {
            if ( monto > 0 ) 
            { 
                cantidad += monto;
            }
            return cantidad;
        }

        public int retirar(int monto)
        {
            return cantidad -= monto;
            
        }

        //Override me permite modificar el comportamiento del metodo que viene heredado
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titular: {titular}");
            sb.AppendLine($"Cantidad: {cantidad}");
            return sb.ToString();
        }


    }
}
