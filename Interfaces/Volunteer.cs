using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Volunteers
{
    interface IVolunteer
    {
        int id { get; set; }
        int branchId { get; set; }
        DateTime birthDate { get; set; }
        DateTime joinDate { get; set; }
        String name { get; set; }
        String phoneNumber { get; set; }
        String email { get; set; }
        String whatsAppNumber { get; set; }
        String region { get; set; }
        String comment { get; set; }
        String university { get; set; }
        String college { get; set; }
        DataModels.DataModels.BranchNames branch { get; set; }
        DataModels.DataModels.EducationLevel education { get; set; }
        DataModels.DataModels.Gender gender { get; set; }
        DataModels.DataModels.CellOperator phoneOpr { get; set; }
    }
}
