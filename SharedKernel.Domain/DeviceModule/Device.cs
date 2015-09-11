using SharedKernel.Domain.BaseModule;

namespace SharedKernel.Domain.DeviceModule
{
    public abstract class Device : Entity
    {
        public string Name { get; set; }
    }
}
