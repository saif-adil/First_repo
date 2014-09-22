using PingYourPackage.API.Model.Dtos;
using PingYourPackage.API.Model.RequestCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiTulgberk.Domain.Entities;


namespace WebApiTulgberk.Api.Controllers
{
    
    [Authorize(Roles = "Admin,Employee")]
    public class ShipmentsController : ApiController
    {
        // Lines removed for brevity
    }

    [Authorize(Roles = "Admin,Employee")]
    public class ShipmentsController : ApiController {
    private readonly IShipmentService _shipmentService;
    public ShipmentsController(IShipmentService shipmentService)
    {
        _shipmentService = shipmentService;
    }

    public PaginatedDto<ShipmentDto> GetShipments(PaginatedRequestCommand cmd)
    {
        var shipments = _shipmentService
        .GetShipments(cmd.Page, cmd.Take);
        return shipments.ToPaginatedDto(
        shipments.Select(sh => sh.ToShipmentDto()));
    }
        // Lines removed for brevity
    }
}