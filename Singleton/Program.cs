using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = "Matias";
            usuario.Password = "123";

            try
            {
                SessionManager.LogIn(usuario);
                SessionManager sesion = SessionManager.GetInstance;
                SessionManager.LogOut();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
