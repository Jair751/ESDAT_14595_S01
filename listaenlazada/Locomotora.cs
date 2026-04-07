using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazada
{
    internal class Locomotora
    {
        private Vagon Primero {  get; set; }
        
        public void AgregarIni(int valor)
        {
            //agregar un dato al inicio
            Vagon nuevo = new Vagon(valor);
            if (this.Primero== null) {
                this.Primero = nuevo;


            }
            else
            {
                Vagon prim = this.Primero;
                nuevo.Sig = prim;
                this.Primero = nuevo; 
            }
        }

        public void Inbsertarfinal (int valor)
        {
            Vagon nuevo = new Vagon (valor);

            if (this.Primero == null)
            {
                this.Primero = nuevo;
                Primero.Sig = null;

            }
            else if (this.Primero.Sig == null)
            {
                this.Primero.Sig = nuevo;
            } else
            {
                Vagon ultimo = Primero;
                while (ultimo.Sig != null)
                {
                    ultimo = ultimo.Sig;
                }
                ultimo.Sig = nuevo;

            }
        }           



        public void Imprime()
        {
            Vagon tmp = Primero;
            while (tmp != null)
            {
                Console.WriteLine($"{tmp.Dato}, ");
                tmp = tmp.Sig;
            }
        }

        public void Eliminar()
        {
            

            if (this.Primero != null || this.Primero.Sig != null)
            {
                Vagon segundo = this.Primero.Sig;
                Vagon tercero = segundo.Sig;
                this.Primero.Sig = tercero;
                segundo.Sig = null;

            }

        }
        public bool BuscarValor(int valorbuscado)
        {
            Vagon tmp = Primero;
            while (tmp != null)
            {
                if (tmp.Dato == valorbuscado)
                {
                    return true;
                    Console.WriteLine($"{tmp.Dato}, ");
                    
                }
                tmp = tmp.Sig;


            }
            return false;
        }


            

        }


    }

