using System;
namespace SucursalBanco
{
    public class Cliente
    {
        #region Atributos
        private string nombre;
        private int monto;
        #endregion

        #region Constructor
        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }
        #endregion

        #region Metodos
        public void Depositar(int m)
        {
            monto = monto + m;
        }

        public void Extraer(int m)
        {
            monto = monto - m;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
        #endregion
    }
}
