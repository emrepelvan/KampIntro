using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1989 && gamer.FirstName == "Emre" && gamer.LastName == "Pelvan" && gamer.IdentityNumber == 22445656420)
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
