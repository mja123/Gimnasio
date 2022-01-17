using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    class TunsManage
    {
        private ITurns turnView;
        private int userId;
        private Model.TurnsModel turnsModel;
        private string stringHour;

        public TunsManage(ITurns view, int userId)
        {
            this.turnView = view;
            this.userId = userId;
        }
        public void createAppointment()
        {
            int result;
            if (this.validateHour())
            {
                turnsModel = new Model.TurnsModel();
                try
                {
                    
                    result = turnsModel.createTurn(convertHour(), convertDate(), userId);
                    turnView.createdTurn(result);
                } catch (Exception e)
                {
                    turnView.createdTurn(500);
                }
                
            }
          
        }

        private bool validateHour()
        {
            if (turnView.appointmentTime() == "-1")
            {
                turnView.createdTurn(400);
                return false;
            }
            return true;
        }
        private string convertHour()
        {


            stringHour = Convert.ToDateTime(this.turnView.appointmentTime()).ToString("HH:mm");
            return stringHour;
        }

        private string convertDate()
        {
            string day = DateTime.Now.ToString("yyyy-MM-dd");

            return day;
        }
    }
}
