using RentallConsumerModel.AccessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentallConsumerModel
{
    public class SearchAllCustomerResponse
    {
        public List<CustomerSeachResult> serachResult { get; set; }
        public ApiMessage message { get; set; }
    }
}
