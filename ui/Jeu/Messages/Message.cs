using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ui.Jeu.Messages
{
    internal  class Message: IMessage
    {
        public  string? Contenu { get; set; }
        public Message(string? contenu = null) { Contenu = contenu; }
    }
}
