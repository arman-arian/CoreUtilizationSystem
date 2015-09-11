using System;

namespace SharedKernel.Domain.BaseModule
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        public void GenerateIdentity()
        {
            Id = Guid.NewGuid();
        }
    }
}
