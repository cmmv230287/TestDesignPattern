using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Prototype.Example1
{
    internal class ProgramCarros
    {
        public static void Execute()
        {
            BaseCar _carFerrai = new Ferrari("Enzo 2012") { precio = 15000000 };
            BaseCar _carMazda = new Mazda("M3 2012") { precio = 10000000 };

            BaseCar _car1 = _carFerrai.Clone();
            _car1.Modelo = "Enzo 2015";
            _car1.SetCaracteristicas(true, false);

            BaseCar _car2 = _carMazda.Clone();
            _car2.Modelo = "M6 2016";
            _car2.precio = 13000000;

            List<BaseCar> _ListCars = new List<BaseCar>();
            int _cont = 1;

            _ListCars.AddRange(new BaseCar[] { _car1, _carFerrai });

            foreach (BaseCar car in _ListCars)
            {
                Console.WriteLine($"********** Carro #{_cont} **********");
                Console.WriteLine($"Modelo: {car.Modelo}");
                Console.WriteLine($"Precio: {car.precio}");
                Console.WriteLine($"Es Automatico: {car._Caracteristicas.Automatico.ToString()}");
                Console.WriteLine($"Tiene GPS: {car._Caracteristicas.Gps.ToString()}");
                Console.WriteLine("");
                _cont++;
            }
        }
    }
}
