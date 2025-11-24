using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr13.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Create {  get; set; }
        public int IdUser { get; set; }
        public Messages() { }
        public Messages(string Message, DateTime Create, int IdUser) 
        {
            this.Message = Message;
            this.Create = Create;
            this.IdUser = IdUser;
        }
    }
}
