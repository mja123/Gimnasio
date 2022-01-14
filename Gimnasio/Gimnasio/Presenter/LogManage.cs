using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    class LogManage
    {
        ILog log;
        private bool newUser;
        private string[] userData;
        private Model.UsersModel userModel;


        public LogManage(ILog log, bool newUser)
        {
            this.log = log;
            userModel = new Model.UsersModel();
            this.newUser = newUser;
            logSelection();
        }
        public void logSelection()
        {
            if (newUser)
            {
                this.createUser();
            }
            else
            {

                this.logInUser();
            }

        }
        public void createUser()
        {
            string[] userData = this.log.dataUser();
            if ((userData[0].Length & userData[1].Length) < 3)
            {
                log.createdUser(406);
            } else
            {
                int result = userModel.createUser(this.log.dataUser());
                log.createdUser(result);
            }

            
        }
        public void logInUser()
        {
            string[] userData = this.log.dataUser();
            if ((userData[0].Length & userData[1].Length) < 3)
            {
                log.createdUser(406);
            }
            else
            {
                int result = userModel.getUser(this.log.dataUser());
                log.getUser(result);
            }
        }
    }
}
