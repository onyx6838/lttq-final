using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        private int Id;
        private string UserName;
        private string PassWord;
        private int Status;
        private int Role;

        public UserDTO(int id, string userName, string passWord, int status, int role)
        {
            Id = id;
            UserName = userName;
            PassWord = passWord;
            Status = status;
            Role = role;
        }

        public UserDTO()
        {
        }

        public UserDTO(string userName, string passWord, int ss)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.Status = ss;
        }
        public UserDTO(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }
        public UserDTO(string userName, string passWord, int status, int role)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.Status = status;
            this.Role = role;
        }

        public string userName { get => UserName; set => UserName = value; }
        public string passWord { get => PassWord; set => PassWord = value; }
        public int status { get => Status; set => Status = value; }
        public int role { get => Role; set => Role = value; }
        public int id { get => Id; set =>Id = value; }
    }
}
