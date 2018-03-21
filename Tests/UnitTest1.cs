using System;
using System.Linq;
using FsCheck;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Prop.ForAll<int[]>(xs => xs.Reverse().Reverse().SequenceEqual(xs))
    .QuickCheckThrowOnFailure();
        }
    }
}
