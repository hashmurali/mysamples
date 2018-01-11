using Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Interfaces
{
   public interface ISettings
    {
        User User { get; set; }
        void Save();
    }
}
