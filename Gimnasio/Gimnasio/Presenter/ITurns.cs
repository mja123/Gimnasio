using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    interface ITurns
    {
        string appointmentTime();
        void createdTurn(int result);
    }
}
