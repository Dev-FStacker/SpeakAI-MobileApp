﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakAI.Services.Models
{
    public class OTPModel
    {
        [JsonProperty("otpCode")]
        public string otpCode { get; set; }
    }
}
