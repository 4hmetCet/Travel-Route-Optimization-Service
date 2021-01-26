using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TravelRouteOptimizationService.Model.Contracts
{
    public class SearchRoutesResponse
    {
        public List<Route> RouteList { get; set; }
    }
}
