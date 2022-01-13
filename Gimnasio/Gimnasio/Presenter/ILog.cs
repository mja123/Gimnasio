using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    interface ILog
    {
        string[] dataUser();
        void createdUser(string result);

        void getUser(string result);
        

    }
}
