using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GameUsersManager : IGameUsersManager
    {
        IUserValidationServices _userValidationServices;

        public GameUsersManager(IUserValidationServices userValidationServices)
        {
            _userValidationServices = userValidationServices;
        }

        public void Add(GameUsers gamer)
        {
            if (_userValidationServices.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Olundu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt başarısız.");
            }
            
        }

        public void Delete(GameUsers gamer)
        {
            Console.WriteLine("Kayıt Silindi!");
        }

        public void Update(GameUsers gamer)
        {
            Console.WriteLine("Kayıt Güncellendi!");
        }
    }
}
