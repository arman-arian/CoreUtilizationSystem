using System.Collections.Generic;
using SharedKernel.Domain.BaseModule;

namespace SharedKernel.Domain.OrganModule
{
    /// <summary>سازمان</summary>
    public class Organization : Entity
    {
        public Organization()
        {
            this.GenerateIdentity();
            this.Branches = new List<Branch>();
        }

        /// <summary>نام</summary>
        public string Name { get; set; }

        /// <summary>امورها</summary>
        public List<Branch> Branches { get; set; } 
    }
}