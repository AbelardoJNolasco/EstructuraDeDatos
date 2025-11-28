using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Cola<Tipo>
    {
        private int _intFrente;
        private int _intFinal;
        private int _intLongitud;
        private Tipo[] Arreglo;

        public Cola(int intTamanio)
        {
            _intFrente = -1;
            _intFinal = -1;
            _intLongitud = intTamanio;
            Arreglo = new Tipo[_intLongitud];
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

        public void Encolar(Tipo dato)
        {
            if (EstaLlena)
                throw new Exception("La cola está llena");

            _intFinal++;
            Arreglo[_intFinal] = dato;

            if (_intFinal == 0)
            {
                _intFrente = 0;
            }
        }

        public Tipo Desencolar()
        {
            if (EstaVacia)
                throw new Exception("La cola está vacía");

            Tipo datoARegresar = Arreglo[_intFrente];
            Arreglo[_intFrente] = default(Tipo);

            if (_intFrente == _intFinal)
            {
                _intFrente = -1;
                _intFinal = -1;
            }
            else
            {
                _intFrente++;
            }

            return (datoARegresar);
        }

        public Tipo LeerUltimo()
        {
            if (EstaVacia)
                throw new Exception("La cola está vacía");

            return (Arreglo[_intFinal]);
        }
    }
}
