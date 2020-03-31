using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Volunteers.DataModels
{
    public class DataModels
    {
        public enum EducationLevel { ELEMENTARY, PRIMARY, SECONDARY, UNIVERSITY, GRADUATE }
        public enum Role { PARTICIPANT, TRAINEE, MEMBER, TEAM_LEADER, BRANCH_MANAGER, EXCUTIVE_MANAGER, GENERAL_MANAGER }
        public enum UserPrivilege { ADMIN, EDITOR }
        public enum Result { SUCCESS, USER_NOT_FOUND, DATABASE_CONNECTION_ERROR, RETURN_TO_ADMIN_ERROR, NONE, DATABASE_ERROR, SESSION_ERROR }
        public enum Gender { MALE, FEMALE }
        public enum CellOperator { VODAFONE, ORGANGE, ETISALAT, WE }
        public enum ConnectionState { OPEN, CLOSER, BROKEN, CONNECTING, EXCUTING, FETCHING }
        public enum BranchNames { NEW_CAIRO, NASR_CITY, MAADI, ALEX, OCOTBER, ELMOHANDESEEN, HELWAN, FAISAL }
        public enum attendenceState{ COMING, MAY_BE, NOT_COMING }
    }
}
