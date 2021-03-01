using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //kullanıcı doğrulama servisi
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);

    }
}
