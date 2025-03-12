

namespace MeetingApp.Models
{
    public static class Repository
    {
        private static readonly List<UserInfo> _users = [];

        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Jon Jones", Email = "jonjones@gmail.com", Phone = "123", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Lionel Messi", Email = "leomessi@gmail.com", Phone = "1234", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Lebron James", Email = "lebronjames@gmail.com", Phone = "12345", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Lewis Hamilton", Email = "lewishamilton@gmail.com", Phone = "123456", WillAttend = true });
        }



        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }


        public static void AddUser(UserInfo userInfo)
        {
            _users.Add(userInfo);
        }
    }
}
