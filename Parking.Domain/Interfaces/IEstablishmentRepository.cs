using Parking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Domain.Interfaces
{
    public interface IEstablishmentRepository : IBaseRepository<Establishment>
    {
        Task<Establishment> GetByCnpj(string cnpj, CancellationToken cancellationToken);
    }
}
