using System;
using System.Diagnostics;

namespace Cowsay.Interfaces
{
    public interface ICowsayService
    {
        string GenerateCowsayMessage(string message);
    }
}
