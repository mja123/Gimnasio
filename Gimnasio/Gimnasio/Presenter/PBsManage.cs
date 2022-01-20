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
            Console.WriteLine(data[0] + "" + data[1] + "" + data[2]);
            if (data[0].Equals("") | data[1].Equals("") | data[2].Equals(""))
            {
                pbView.pbCreated(404);
            } else
            {
                result = pbModel.newPb(data, userId);
                pbView.pbCreated(result);
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
