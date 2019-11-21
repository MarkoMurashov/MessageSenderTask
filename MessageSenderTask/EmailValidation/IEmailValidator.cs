using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidation
{
    public interface IEmailValidator
    {
        bool IsValid(string email);
    }
}
