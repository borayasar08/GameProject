using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameUsersManager gameUsersManager = new GameUsersManager(new UserValidationManager() );
            gameUsersManager.Add(new GameUsers { BirthYear = 2001, FirstName = "Bora Yiğit", LastName = "Yaşar", IdentityNumber= 11});

        }
    }
}
