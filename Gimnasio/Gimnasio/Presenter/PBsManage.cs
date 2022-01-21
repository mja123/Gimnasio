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
            this.pbView = view;
            this.userId = userId;
            pbModel = new Model.PBsModel();
        }
        public void createPB()
        {
            ArrayList data = pbView.createData();

            if (data.Count < 3)
            {
                pbView.pbCreated(409);
            } else
            {

                if (data[0].Equals("") | data[1].Equals("") | data[2].Equals(""))
                {
                    pbView.pbCreated(404);
                }
                else if ((!Utils.MaxCountOfChars.isAllow(data[0].ToString(), 40)) |
                    (!Utils.MaxCountOfChars.isAllow(data[0].ToString(), 10)) |
                    (!Utils.MaxCountOfChars.isAllow(data[0].ToString(), 10)))
                {
                    Console.WriteLine("here");
                    pbView.pbCreated(414);
                }
                else if (data[1].GetType() != typeof(int) | data[2].GetType() != typeof(int))
                {
                    pbView.pbCreated(409);

                }
                else
                {
                    result = pbModel.newPb(data, userId);
                    pbView.pbCreated(result);
                }

            }


        }

        public void filterPB()
        {
            string exercise;

            exercise = pbView.filterDelete();

            pbView.pbGet(pbModel.getOnePB(exercise, userId));


        }
        
        public void deletePB()
        {
            result = pbModel.deletePb(pbView.filterDelete(), userId);
            pbView.pbDeleted(result);
        }
        public void getAllOfPBs()
        {
            try
            {
                pbView.pbsGet(pbModel.getPBs(userId));
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " getAllOfAppointments");
            }
        }

    }

}
