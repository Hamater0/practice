using System;
using System.Collections.Generic;
using System.Text;

namespace С_Practice.Common
{
    public interface ITask
    {
        string Title { get; }
        string Description { get; }
        string[] Requirements { get; }
        void Run();
    }
}
