using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPomoApp
{
    internal class User
    {
        public int UserID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Wallet {  get; set; }
    }
}
