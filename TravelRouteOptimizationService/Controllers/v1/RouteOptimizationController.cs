using System;
using Microsoft.AspNetCore.Mvc;
using TravelRouteOptimizationService.Model.Contracts;
using TravelRouteOptimizationService.Services.ServiceImplementations;

namespace TravelRouteOptimizationService.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RouteOptimizationController : ControllerBase
    {
       
        private readonly IRouteOptimizationService _routeOptimizationService;


        public RouteOptimizationController(IRouteOptimizationService routeOptimizationService)
        {
            this._routeOptimizationService = routeOptimizationService;
        }

        [HttpPost]
        [Route("Route")]
        public ActionResult Route(RouteRequest routeRequest)
        {
            try
            {
            }
            catch (Exception ex) {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPost]
        [Route("SaveRoute")]
        public ActionResult SaveRoute(SaveRouteRequest saveRouteRequest)
        {
            try
            {
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPost]
        [Route("SearchRoutes")]
        public ActionResult SearchRoutes(SearchRoutesRequest searchRoutesRequest)
        {
            try
            {
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
