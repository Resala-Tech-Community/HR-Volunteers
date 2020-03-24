namespace Resala
{
    public class Session
    {
        private static Session session;
        
        private Volunteer user= new Volunteer();


        private Session(int ID)
        {
            this.user = user.getData(ID);
        }

        public static Session getSession()
        {
            return session;
        }

        public void logOut()
        {
            session = null;
        }
    }
}