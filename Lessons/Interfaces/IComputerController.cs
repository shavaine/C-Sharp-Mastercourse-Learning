using System;

namespace Interfaces
{
    public interface IComputerController: IDisposable
    {
        void Connect();
        void CurrentKeyPressed();
    }
}
