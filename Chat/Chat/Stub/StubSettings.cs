using Chat.Interfaces;
using Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Stub
{
    public class StubSettings : ISettings
    {
        public User User { get; set; }
        public void Save() { }
    }
}
