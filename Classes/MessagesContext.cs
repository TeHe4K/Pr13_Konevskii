using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr13.Models;
using Pr13.Interfaces;

namespace Pr13.Classes
{
    public class MessagesContext: Messages, IMessages
    {
        public static List<Messages> AllMessages;
        public MessagesContext() => All(out AllMessages);
        public MessagesContext(string Message, DateTime Create, int IdUser) : base(Message, Create, IdUser) { }
        public void All(out List<Messages> Messages) => Messages = new List<Messages>();
        public void Delete() => AllMessages.Remove(this);
        public void Save(bool Update = false)
        {
            if(!Update)
                AllMessages.Add(this);
        }
    }
}
