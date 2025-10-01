using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros.Dao
{
    public class UsuarioDao
    {
        public String[] users = { "Ramcess", "Rata", "Carlos" };
        public String[] passwords = { "123", "456", "789" };

        public Boolean Validar(String user, String password)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Equals(user) && passwords[i].Equals(password))
                {
                    return true;
                }

            }return false;
        }
    }
}
