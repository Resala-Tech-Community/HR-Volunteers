using System.Runtime.CompilerServices;

namespace Resala
{
    public class TeamLeader:Volunteer
    {

        public void getBranchKPi(string activity)
        {
            KPI kpi = new KPI();
            kpi.getBranchKPI(this.branchName,activity);
        }

        public void getBranchKpi(string branchName, string activity)
        {
            throw new System.NotImplementedException();
        }

        public void assignVolunteersToMember(int ID, string[] volunteersPhone)
        {
            
        }

        public void reviewTeamWork()
        {
            
        }

    }
}