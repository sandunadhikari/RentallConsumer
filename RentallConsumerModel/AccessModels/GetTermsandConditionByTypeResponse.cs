﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentallConsumerModel.AccessModels
{
    public class GetTermsandConditionByTypeResponse
    {
        public ApiMessage message { get; set; }
        public List<Terms> termlist { get; set; }
    }
}
