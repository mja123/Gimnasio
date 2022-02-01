using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    interface ILog
    {
        //Canal de comunicación entre Presenter y View.
        string[] dataUser();
        void createdUser(int result);

        void getUser(int result);
    }
}
