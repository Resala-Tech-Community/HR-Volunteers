using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resala
{
    public class Event
    {
        public int ID, BR_ID, attendanceCount;
        public DateTime startDate, dueDate;
        public List<Branch> includedBranches;
        public string description;
        public string name;

        public List<int> getAttendanceList()
        {
            return null;
        }

        public void add(string name, DateTime startDate, DateTime dueDate, int BR_ID)
        {


        }

        public void getID(DateTime date, int BR_ID)
        {

        }

        public void update(int ID)
        {
            //API CALL
        }

        public void getResult(int id)
        {
            
        }

        public void getReport(int id)
        {
            
        }
    }
}
