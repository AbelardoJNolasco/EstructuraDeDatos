using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Pila
    {
        private int _intTop;
        private int _intTamanio;
        private char[] Arreglo;

        public Pila(int Tamanio)
        {
            _intTop = 0;
            _intTamanio = Tamanio;
            Arreglo = new char[_intTamanio];
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

        public void Push(char chrCadenaCaracter)
        {
            if (EstaLlena)
                throw new Exception("La pila está llena");

            Arreglo[_intTop] = chrCadenaCaracter;
            _intTop++;
        }

        public char Pop()
        {
            if (EstaVacia)
                throw new Exception("La pila está vacía");

            _intTop--;
            char chrCaracterRegreso = Arreglo[_intTop];
            Arreglo[_intTop] = default(char);

            return (chrCaracterRegreso);
        }

        public char LeerTope()
        {
            if (EstaVacia)
                throw new Exception("La pila está vacía");

            return (Arreglo[_intTop]);
        }
    }
}
