using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Cola
    {
        private int _intFrente;
        private int _intFinal;
        private int _intLongitud;
        private char[] Arreglo;

        public Cola(int intTamanio)
        {
            _intFrente = -1;
            _intFinal = -1;
            _intLongitud = intTamanio;
            Arreglo = new char[_intLongitud];
        }

        public bool EstaVacia
        {
            get
            {
                if (_intFrente == -1)
                    return (true);
                else
                    return (false);
            }
        }

        public bool EstaLlena
        {
            get
            {
                if (_intFinal == _intLongitud - 1)
                    return (true);
                else
                    return (false);
            }
        }

        public void Encolar(char chrCadenaCaracter)
        {
            if (EstaLlena)
                throw new Exception("La cola está llena");

            _intFinal++;
            Arreglo[_intFinal] = chrCadenaCaracter;

            if (_intFinal == 0)
            {
                _intFrente = 0;
            }
        }

        public char Desencolar()
        {
            if (EstaVacia)
                throw new Exception("La cola está vacía");

            char chrCadenaCaracter = Arreglo[_intFrente];
            Arreglo[_intFrente] = default(char);

            if (_intFrente == _intFinal)
            {
                _intFrente = -1;
                _intFinal = -1;
            }
            else
            {
                _intFrente++;
            }

            return (chrCadenaCaracter);
        }

        public char LeerUltimo()
        {
            if (EstaVacia)
                throw new Exception("La cola está vacía");

            return (Arreglo[_intFinal]);
        }
    }
}
