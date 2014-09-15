using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTulgberk.Domain.Entities;

namespace WebApiTulgberk.Domain.Extension
{
    public static class ShipmentStateRepositoryExtensions
    {

        public static IQueryable<ShipmentState> GetAllByShipmentKey(
            this IEntityRepository<ShipmentState> shipmentStateRepository, Guid shipmentKey)
        {

            return shipmentStateRepository.GetAll()
                .Where(x => x.ShipmentKey == shipmentKey);
        }
    }
}
