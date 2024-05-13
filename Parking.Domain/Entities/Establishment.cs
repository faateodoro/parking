using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Domain.Entities
{
    public sealed class Establishment : BaseEntity
    {
        public string Name { get; private set; }
        public string Cnpj { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public int MotorcycleVacancy { get; private set; }
        public int CarVacancy { get; private set; }

        public Establishment(string name, string cnpj, string address, string phone, int motorcycleVacancy, int carVacancy)
        {
            Name = name;
            Cnpj = cnpj;
            Address = address;
            Phone = phone;
            MotorcycleVacancy = motorcycleVacancy;
            CarVacancy = carVacancy;
        }
    }
}
