﻿using System.Net;

namespace Villa_Web.Models
{
    public class APIReponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorsMessages { get; set; }

        public object Result { get; set; }
    }
}