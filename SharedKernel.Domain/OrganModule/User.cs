using SharedKernel.Domain.BaseModule;

namespace SharedKernel.Domain.OrganModule
{
    /// <summary>کاربر</summary>
    public class User : Entity
    {
        public User()
        {
            this.GenerateIdentity();
        }

        /// <summary>نام و نام خانوادگی</summary>
        public string FullName { get; set; }

        /// <summary>نام کاربری</summary>
        public string UserName { get; set; }

        /// <summary>رمز عبور</summary>
        public string Password { get; set; }
    }
}