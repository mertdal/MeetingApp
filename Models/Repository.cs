using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository(){
            _users.Add(new UserInfo(){Id =1 ,Name = "Mert Dal", Email = "adrenalinmert@gmail.com",Phone = "05324754014",WillAttend=true});
            _users.Add(new UserInfo(){Id =2 ,Name = "Fatma Sönmez Çakır", Email = "fsc@bartin.edu.tr",Phone = "05317329684",WillAttend=true});
            _users.Add(new UserInfo(){Id =3 ,Name = "Alper Aytekin", Email = "aytekin@bartin.edu.tr",Phone = "05058376351",WillAttend=false});
        }
        public static List<UserInfo> Users {
            get {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}