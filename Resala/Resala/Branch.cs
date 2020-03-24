using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resala
{
    public class Branch
    {
        public enum BranchNames
        {
            NEW_CAIRO,
            NASR_CITY,
            MAADI,
            ALEX,
            OCOTBER,
            ELMOHANDESEEN,
            HELWAN,
            FAISAL
        }

        public BranchNames name; 
        public string code, leaderID;
        public int BR_ID;
        
        public Branch (int BR_ID)
        {
            this.BR_ID = BR_ID; 

            // retrive branch data

        }

        public void getVolAnaylsis()
        {

        }

        public void getCommAnalysis()
        {

        }

        public void getQwafelList() 
        {

        }

        public void archive(int[] IDs)
        {

        }

        private void getBranchInfo(int BR_ID)
        {

        }
    }
}
