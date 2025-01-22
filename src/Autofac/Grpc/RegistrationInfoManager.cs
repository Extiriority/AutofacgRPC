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

        public void UpdateRegistrationInfo(Guid id, string component, string service, string lifetime, List<string> dependencies, List<string> implementation)
        {
            RegistrationInfo.Id = id;
            RegistrationInfo.Component = component;
            RegistrationInfo.Service = service;
            RegistrationInfo.Lifetime = lifetime;
            RegistrationInfo.Dependencies = dependencies;
            RegistrationInfo.Implementations = implementation;
        }
    }
}
