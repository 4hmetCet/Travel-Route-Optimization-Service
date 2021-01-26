using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelRouteOptimizationService.Model.Contracts
{
    public class SearchRoutesRequest
    {
        public string UserUID { get; set; }

        public string Bounds { get; set; }
    }
}
