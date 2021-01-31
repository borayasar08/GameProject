using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class UserValidationManager : IUserValidationServices
    {
        public bool Validate(GameUsers gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "Bora Yiğit" && gamer.LastName=="Yaşar" && gamer.IdentityNumber == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
