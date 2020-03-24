namespace Resala
{
    public class CEO:Volunteer
    {

        public void getBranchKPI(Branch.BranchNames name , string activity)
        {
            KPI kpi= new KPI();
            kpi.getBranchKPI(name,activity);
        }
    }
}