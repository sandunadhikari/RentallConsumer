﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentallConsumerModel
{
    public class GetCustomerAgreementReservationCountResponse
    {
        public AgreementReservationCount custTotcount { get; set; }
        public ApiMessage message { get; set; }
    }
}
