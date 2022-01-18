using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    class TunsManage
    {
        private ITurns turnView;
        private int userId, result;
        private Model.TurnsModel turnsModel;
        private string day, hour;

        public TunsManage(ITurns view, int userId)
        {
            turnsModel = new Model.TurnsModel();
            this.turnView = view;
            this.userId = userId;
        }
        public void createAppointment()
        {
            if (this.validateHour())
            {
                day = convertDay();
                hour = convertHour();                
                try
                {
                    result = turnsModel.createTurn(hour, day, userId);
                    turnView.createdTurn(result);
                } catch (Exception e)
                {
                    turnView.createdTurn(500);
                }
            }
        }

        public void getAllOfAppointments(int userId)
        {
            try
            {                
                turnView.getTurns(turnsModel.getAppoitments(userId));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " getAllOfAppointments");
            }
        }
        public void deleteAppointment()
        {
            if (this.validateHour())
            {
                day = convertDay();
                hour = convertHour();

                try
                {
                    result = turnsModel.deleteTurn(hour, day, userId);
                    turnView.deletedTurn(result);
                }
                catch (Exception e)
                {
                    turnView.deletedTurn(500);
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
            hour = Convert.ToDateTime(this.turnView.appointmentTime()).ToString("HH:mm");
            return hour;
        }

        private string convertDay()
        {
            string day,formatedDay;

            day = turnView.appointmentDay();

            formatedDay = DateTime.Parse(day).Date.ToString("yyyy-MM-dd");

            return formatedDay;

        }
    }
}
