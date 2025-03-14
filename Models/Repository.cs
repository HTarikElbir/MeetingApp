﻿

namespace MeetingApp.Models
{
    public static class Repository
    {
        private static readonly List<UserInfo> _users = [];

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Jon Jones", Email = "jonjones@gmail.com", Phone = "123", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Lionel Messi", Email = "leomessi@gmail.com", Phone = "1234", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Lebron James", Email = "lebronjames@gmail.com", Phone = "12345", WillAttend = true });
            _users.Add(new UserInfo() { Id = 4, Name = "Lewis Hamilton", Email = "lewishamilton@gmail.com", Phone = "123456", WillAttend = true });
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
            userInfo.Id = _users.Count + 1;
            _users.Add(userInfo);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
