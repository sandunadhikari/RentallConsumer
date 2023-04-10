using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentallConsumerModel.AccessModels
{
    [Serializable]
    public class GetAllLocationForClientIDForMobileResponse
    {
        public List<LocationModel> locationList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ApiMessage message { get; set; }
    }
}
