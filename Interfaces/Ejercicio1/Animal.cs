using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Animal : IAnimal
    {
        public bool Andar(int value)
        {
            throw new NotImplementedException();
        }

        public bool EsPerro()
        {
            return true;
        }

        public void Saltar()
        {
            throw new NotImplementedException();
        }
    }

    interface IAnimal
    {
        bool Andar(int value);
        bool EsPerro();
        void Saltar();
    }


}
