using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatContracts;

namespace ChatServer
{
    public class ChatService : IChatService
    {
        public string TestConnection()
        {
            return "Chat server is working!";
        }
    }
}