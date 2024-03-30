using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;


namespace Diary
{
    public class User
    {
        

        public int Id { get; set; }
        public string FIO { get; set; }
        public int IsAdmin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Group { get; set; }
        public string Post { get; set; }
        public string Institute { get; set; }
        public string Speciality { get; set; }



        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }


        public User(string fio,
            int is_admin,
            string email,
            string password,
            string group_id,
            string post,
            string institute,
            string speciality)
        {
            IsAdmin = is_admin;
            Email = email;
            Password = password;
            Group = group_id;
            Post = post;
            Institute = institute;
            Speciality = speciality;



        }

        public User(string fio, 
            string email, 
            string password)
        {

            FIO = fio;
            Email = email;
            Password = password;

        }

        public User()
        {
        }
        
    }
}
