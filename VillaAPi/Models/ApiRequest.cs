﻿using Microsoft.OpenApi.Writers;
using static Villa_Utillity.SD;

namespace VillaAPi.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data {  get; set; }
    }
}
