using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    interface IPB
    {
        //Canal de comunicación entre el Presenter y la View.
        ArrayList createData();
        void pbCreated(int result);
        string filterDelete();
        void pbDeleted(int result);
        void pbsGet(DataTable pbs);
        void pbGet(DataTable pb);
    }
}
