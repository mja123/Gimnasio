using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    class PBsManage
    {
        private IPB pbView;
        private int userId;
        private Model.PBsModel pbModel;
        private int result;
        public PBsManage(IPB view, int userId)
        {
            //Inicializa e instancia las variables.
            this.pbView = view;
            this.userId = userId;
            pbModel = new Model.PBsModel();
        }
        public void createPB()
        {
            //Llama al método de Model de crear PB y responde a la View.
            ArrayList data = pbView.createData();            
            if (data.Count < 3)
            {
                //Valida si se han ingresado los 3 datos necesarios para la creación del PB.
                pbView.pbCreated(409);
            }
            else {
                if (!this.pbExist(data))
                {
                    //Pregunta si el PB ya existe.
                    if (data[0].Equals("") | data[1].Equals("") | data[2].Equals(""))
                    {
                        //Valida si enviaron datos vacíos.
                        pbView.pbCreated(404);
                    }
                    else if ((!Utils.MaxCountOfChars.isAllow(data[0].ToString(), 40)) |
                        (!Utils.MaxCountOfChars.isAllow(data[1].ToString(), 10)) |
                        (!Utils.MaxCountOfChars.isAllow(data[2].ToString(), 10)))
                    {
                        //Valida la cantidad máxima de caracteres.                        
                        pbView.pbCreated(414);
                    }
                    else if (data[1].GetType() != typeof(int) | data[2].GetType() != typeof(int))
                    {
                        //Valida si el peso y las repeticiones son enteros.
                        pbView.pbCreated(409);

                    }
                    else
                    {
                        //Llama al Model y responde a la View.
                        result = pbModel.newPb(data, userId);
                        pbView.pbCreated(result);
                    }
                }
                else
                {
                    pbView.pbCreated(400);
                }
            }            
        }

        public void filterPB()
        {
            //Filtra un ejercicio.
            string exercise;

            exercise = pbView.filterDelete();

            pbView.pbGet(pbModel.getOnePB(exercise, userId));


        }
        
        public void deletePBExercise()
        {
            //Elimina los PBs de un ejercicio.

            result = pbModel.deletePbExercise(pbView.filterDelete(), userId);
            pbView.pbsDeleted(result);
        }
        public void getAllOfPBs()
        {
            //Llama al Model para solicitar todos los PBs del usuario y responde a la View.
            try
            {
                pbView.pbsGet(pbModel.getPBs(userId));
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " getAllOfAppointments");
            }
        }

        public void deletePb()
        {
            //Llena pbData con la información de la interfaz y llama al método del modelo.
            ArrayList pbData = new ArrayList();

            pbData = pbView.pbDataToDelete();

            //Valida si el array está vacío, es decir, si no hay filas disponibles en la tabla.
            if (pbData.Count > 0)
            {
                pbView.pbDeleted(pbModel.deletePb(pbData, userId));
            } else
            {
                pbView.pbDeleted(400);
            }
                
        }

        private bool pbExist(ArrayList pbInfo)
        {
            //Método interno que valida si el PB existe.
            string excercise = pbInfo[0].ToString();
            int weight = Convert.ToInt32(pbInfo[1]);
            int reps = Convert.ToInt32(pbInfo[2]);

            if (pbModel.pbExist(excercise, weight, reps, userId))
            {
                return true;
            }
            return false;           
        }
    }
}
