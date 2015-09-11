using System.Collections.Generic;
using SharedKernel.Domain.BaseModule;

namespace SharedKernel.Domain.OrganModule
{
    /// <summary>امور</summary>
    public class Branch : Entity
    {
        public Branch()
        {
            this.GenerateIdentity();
            this.Users = new List<User>();
        }

        /// <summary>نام</summary>
        public string Name { get; set; }

        /// <summary>کاربران</summary>
        public List<User> Users { get; set; } 
    }
}
