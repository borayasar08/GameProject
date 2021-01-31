using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IGameUsersManager
    {
        void Add(GameUsers gamer);
        void Update(GameUsers gamer);
        void Delete(GameUsers gamer);

    }
}
