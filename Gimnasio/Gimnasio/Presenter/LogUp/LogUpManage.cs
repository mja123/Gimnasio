using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter.LogUp
{
    class LogUpManage
    {
        ILog log;
        Model.UsersModel usersModel = null;
        public LogUpManage(ILog log)
        {
            this.log = log;
            usersModel = new Model.UsersModel();
        }

        public string createUser()
        {
           string result = usersModel.createUser(this.log.dataUser());
            return result;

        }



    }
}
