using System;
namespace MaxibonKataCSharp
{
    public struct Slack : IChat
    {
        public void Send(string message)
        {
            Console.WriteLine("-------->" + message);
        }
    }
}
