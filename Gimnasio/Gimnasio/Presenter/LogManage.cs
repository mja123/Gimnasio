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
        private int result;

        public LogManage(ILog log, bool newUser)
        {
            this.log = log;
            userModel = new Model.UsersModel();
            this.newUser = newUser;
            userData = log.dataUser();
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
            Console.WriteLine(userData[0] + " " + userData[0].Length);
            Console.WriteLine(userData[1]+ " "+ userData[1].Length);
            if ((userData[0].Length & userData[1].Length) >= 3)
            {
                if ((userData[0].Length & userData[1].Length) < 20)
                {
                    userData[1] = Codify.toEncode(userData[1]);

                    result = userModel.createUser(userData);
                    log.createdUser(result);
                } else {
                    log.createdUser(404);
                }
                    
                
            } else
            {
                log.createdUser(406);
            }

            
        }
        public void logInUser()
        {
            
            if ((userData[0].Length & userData[1].Length) > 3)
            {
                userData[1] = Codify.toEncode(userData[1]);   
                result = userModel.getUser(userData);
                log.getUser(result);
             
            }
            else
            {
                log.createdUser(406);
            }
        }
    }
}
