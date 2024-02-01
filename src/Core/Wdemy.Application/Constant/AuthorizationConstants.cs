using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wdemy.Application.Constant
{
    public static class AuthorizationConstants
    {
        public const string DEFAULT_ADMIN_USER = "mesutkilic@tureb.com";
        public const string DEFAULT_TRAINER_USER = "mesutkilic@tureb.com";
        public const string DEFAULT_STUDENT_USER = "mesutkilic@tureb.com";
        public const string DEFAULT_PASSWORD = "Tureb123";

        public static class Roles
        {
            public const string ADMINISTRATOR = "Admin";
            public const string TRAINER = "Trainer";
            public const string STUDENT = "Student";
        }
    }
}
