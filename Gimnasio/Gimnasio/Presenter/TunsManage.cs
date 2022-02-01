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
            //Se instancian las varaiables.
            turnsModel = new Model.TurnsModel();
            this.turnView = view;
            this.userId = userId;
        }
        public void createAppointment()
        {
            if (this.validateHour())
            {
                //Pregunta si se ingresó una hora.
                //Convierte el día y la hora en un formato apto para la bd.
                day = convertDay();
                hour = convertHour();                
                try
                {
                    //Se llama al método del Model que crea el turno.
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
            //Llama al método del Model para mostrar todos los turnos del usuario.
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
            //Llama al método del Model para eliminar un usuario
            if (this.validateHour())
            {
                //Valida si se ingresó la fecha y la hora del turno a cancelar.
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
            //Valida si se ingresó una hora
            if (turnView.appointmentTime() == "-1")
            {
                turnView.createdTurn(400);
                return false;
            }
            return true;
        }
        private string convertHour()
        {            
            //Formatea el horario que ingreso el usuario en uno apto para la bd.
            hour = Convert.ToDateTime(this.turnView.appointmentTime()).ToString("HH:mm");
            return hour;
        }

        private string convertDay()
        {
            //Formatea el día que ingreso el usuario en uno apto para la bd.
            string day,formatedDay;

            day = turnView.appointmentDay();

            formatedDay = DateTime.Parse(day).Date.ToString("yyyy-MM-dd");

            return formatedDay;

        }
    }
}
