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
            RouteResponse routeResponse = new RouteResponse();
            try
            {
            }
            catch (Exception ex) {
                return BadRequest();
            }
            return Ok(routeResponse);
        }

        [HttpPost]
        [Route("SaveRoute")]
        public ActionResult SaveRoute(SaveRouteRequest saveRouteRequest)
        {
            SaveRouteResponse saveRouteResponse = new SaveRouteResponse();
            try
            {
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
            return Ok(saveRouteResponse);
        }

        [HttpPost]
        [Route("SearchRoutes")]
        public ActionResult SearchRoutes(SearchRoutesRequest searchRoutesRequest)
        {
            SearchRoutesResponse searchRoutesResponse = new SearchRoutesResponse();
            try
            {
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
            return Ok(searchRoutesResponse);
        }

    }
}
