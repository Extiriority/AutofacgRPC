using System.Collections.Generic;

namespace Grpc
{
    public class RegistrationInfo
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Service { get; set; }

        public List<string> Implementations { get; set; }

        public List<string> Dependencies { get; set; }
    }
}
