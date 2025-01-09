using System;
using System.Collections.Generic;

namespace Grpc
{
    public class RegistrationInfoManager
    {
        private static readonly Lazy<RegistrationInfoManager> _instance = new Lazy<RegistrationInfoManager>(() => new RegistrationInfoManager());

        public static RegistrationInfoManager Instance => _instance.Value;

        public RegistrationInfo RegistrationInfo { get; private set; }

        private RegistrationInfoManager()
        {
            RegistrationInfo = new RegistrationInfo();
        }

        public void UpdateRegistrationInfo(string id, string name, string service, List<string> dependencies, List<string> implementation)
        {
            RegistrationInfo.Id = id;
            RegistrationInfo.Name = name;
            RegistrationInfo.Service = service;
            RegistrationInfo.Dependencies = dependencies;
            RegistrationInfo.Implementations = implementation;
        }
    }
}
