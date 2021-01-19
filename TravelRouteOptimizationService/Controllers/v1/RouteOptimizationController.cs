using System;
using Microsoft.AspNetCore.Mvc;
using TravelRouteOptimizationService.Services.ServiceImplementations;

namespace TravelRouteOptimizationService.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RouteOptimizationController : ControllerBase
    {
       
        private readonly IRouteOptimizationService _routeOptimizationService;


        RouteOptimizationController(IRouteOptimizationService routeOptimizationService)
        {
            this._routeOptimizationService = routeOptimizationService;
        }

        [HttpPost]
        [Route("Route")]
        public ActionResult Route(String test)
        {
            return Ok();
        }

        [HttpPost]
        [Route("SaveRoute")]
        public ActionResult SaveRoute(String test)
        {
            return Ok();
        }

        [HttpPost]
        [Route("SearchRoutes")]
        public ActionResult SearchRoutes(String bound)
        {
            return Ok();
        }

    }
}
