using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Pila<Tipo>
    {
        private int _intTop;
        private int _intTamanio;
        private Tipo[] Arreglo;

        public Pila(int Tamanio)
        {
            _intTop = 0;
            _intTamanio = Tamanio;
            Arreglo = new Tipo[_intTamanio];
        }

        public bool EstaVacia
        {
            get
            {
                if (_intTop == 0)
                    return (true);
                else
                    return (false);
            }
        }

        public bool EstaLlena
        {
            get
            {
                if (_intTop == _intTamanio)
                    return (true);
                else
                    return (false);
            }
        }

        public void Push(Tipo dato)
        {
            if (EstaLlena)
                throw new Exception("La pila está llena");

            Arreglo[_intTop] = dato;
            _intTop++;
        }

        public Tipo Pop()
        {
            if (EstaVacia)
                throw new Exception("La pila está vacía");

            _intTop--;
            Tipo datoARegresar = Arreglo[_intTop];
            Arreglo[_intTop] = default(Tipo);

            return (datoARegresar);
        }

        public Tipo LeerTope()
        {
            if (EstaVacia)
                throw new Exception("La pila está vacía");

            return (Arreglo[_intTop]);
        }
    }
}
