using System.Collections.Generic;
using System.Text;

namespace TryoutPatterns
{
    interface ICommand
    {
        string Name { get; }
        void Act();
    }

}
