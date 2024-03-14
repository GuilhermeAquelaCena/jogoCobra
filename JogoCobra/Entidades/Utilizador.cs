using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCobra.Entidades
{
    internal class Utilizador
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public byte Level { get; private set; }
        public int Score { get; private set; }

        public Utilizador(string username, string password)
        {
            Username=username;
            Password=password;
            Level = 1;
            Score = 0;
        }

    }
}
