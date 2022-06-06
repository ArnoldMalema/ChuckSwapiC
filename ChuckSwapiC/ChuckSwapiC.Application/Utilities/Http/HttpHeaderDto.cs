using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckSwapiC.Application.Utilities.Http
{
    public class HttpHeaderDto
    {
        private readonly string name;
        private readonly string value;

        public HttpHeaderDto(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public string Name => name;

        public string Value => value;
    }
}
