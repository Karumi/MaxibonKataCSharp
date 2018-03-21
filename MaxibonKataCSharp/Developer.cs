using System;
namespace MaxibonKataCSharp
{
    public struct Developer
    {
        public string Name { get; }
        public int NumberOfMaxibonsToGet { get; }

        public Developer(string name, int numberOfMaxibonsToGet)
        {
            Name = name;
            NumberOfMaxibonsToGet = numberOfMaxibonsToGet < 0 ? 0 : numberOfMaxibonsToGet;
        }
    }
}
