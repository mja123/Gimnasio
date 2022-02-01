using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    class LogManage
    {
        private ILog log;
        private bool newUser;
        private string[] userData;
        private Model.UsersModel userModel;
        private int result;

        public LogManage(ILog log, bool newUser)
        {
            //Inicializa las variables y pregunta que tipo de log se realizó.
            this.log = log;
            userModel = new Model.UsersModel();
            this.newUser = newUser;
            userData = log.dataUser();
            logSelection();
        }
        private void logSelection()
        {
            //Decide si se están registrando o si están ingresando y llama al metodo correspondiente
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

            if ((userData[0].Length >= 3) & (userData[1].Length >= 3))
            {
                //Validación de cantidad mínima y máxima de caracteres en la creación.
                if ((Utils.MaxCountOfChars.isAllow(userData[0], 20)) &
                    (Utils.MaxCountOfChars.isAllow(userData[1], 20)))
                {
                    //Cambia la contraseña a un array de bytes y llama al Model.
                    userData[1] = Codify.toEncode(userData[1]);

                    result = userModel.createUser(userData);

                    log.createdUser(result);
                } else {
                    log.createdUser(414);
                }
                                    
            } else
            {
                log.createdUser(406);
            }            
        }
        public void logInUser()
        {            
            if ((userData[0].Length >= 3)  & (userData[1].Length >= 3))
            {
                //Validación de cantidad mínima y máxima de caracteres en el ingreso del usuario.
                //Cambia la contraseña ingresada a su equivalente en bytes para comparar en la base de datos.
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
