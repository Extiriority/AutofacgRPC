using System;
using System.Collections.Generic;

namespace Grpc
{
    public class RegistrationInfo
    {
        public Guid Id { get; set; }

        public string Component { get; set; }

        public string Service { get; set; }

        public string Lifetime { get; set; }

        public List<string> Implementations { get; set; }

        public List<string> Dependencies { get; set; }
    }
}
