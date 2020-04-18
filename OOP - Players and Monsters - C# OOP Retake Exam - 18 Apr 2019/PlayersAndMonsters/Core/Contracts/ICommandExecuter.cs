using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Core.Contracts
{
    public interface ICommmandExecuter
    {
        string ExecuteCommand(string command);
    }
}
