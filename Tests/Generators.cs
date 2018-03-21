using System;
using FsCheck;
using MaxibonKataCSharp;

namespace Tests
{
    public static class Generators
    {
        public static Arbitrary<Developer> Developers()
        {
            return Arb.From<Developer>();
        }

        public static Arbitrary<Developer> HungryDeveloperGenerator()
        {
            return Developers().Filter(developer => developer.NumberOfMaxibonsToGet >= 8);
        }

        public static Arbitrary<Developer> NotSoHungryDeveloperGenerator()
        {
            return Developers().Filter(developer => developer.NumberOfMaxibonsToGet < 8);
        }

        public static Gen<Developer> KarumieGenerator()
        {
            return Gen.OneOf(
                Gen.Constant(Karumies.DAVIDE),
                Gen.Constant(Karumies.PEDRO),
                Gen.Constant(Karumies.FRAN),
                Gen.Constant(Karumies.JORGE),
                Gen.Constant(Karumies.SERGIO),
                Gen.Constant(Karumies.TONI)
            );
        }
    }
}
