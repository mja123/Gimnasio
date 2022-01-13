using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter.LogIn
{
    class LogInManage
    {
        ILog log;
        private Model.UsersModel userModel;
        public LogInManage(ILog log)
        {
            this.log = log;
            userModel = new Model.UsersModel();
        }

        public void logInUser()
        {
            string result = userModel.getUser(log.dataUser());
            log.getUser(result);

        }
    }
}
