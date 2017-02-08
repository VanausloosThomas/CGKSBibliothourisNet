using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliothouris.Source.Users;
using Bibliothouris.Forms.Users;

namespace Bibliothouris
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserController userController = new UserController(new UsersForm(), new UserAddForm(), new UserService());
            userController.view.ShowDialog();
        }
    }
}
