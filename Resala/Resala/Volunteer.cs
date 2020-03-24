using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resala
{
    public class Volunteer 
    {
        public int ID, BR_ID;
        public DateTime DOB, joinDate;
        public string name, phoneNum, Email, whatsappNum, region;
        private string comment="";
        public string university, college;
        public Branch.BranchNames branchName;
        private DataModels.EducationLevel education;
        private DataModels.Gender gender;
        private DataModels.CellOperator phoneOpr;
        
        public int add()
        {

            return 0;
        }

        public void update(int VolunteerID)
        {

        }

        public int getID(string phone, string name = "")
        {

            return 0;

        }

        public Volunteer getData(int ID)
        {
            return null;
        }

        public void archive()
        {

        }
    }
}