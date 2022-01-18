using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    interface ITurns
    {
        string appointmentTime();

        string appointmentDay();
        void createdTurn(int result);

        void getTurns(DataTable turns);

        void deletedTurn(int result);
    }
}
