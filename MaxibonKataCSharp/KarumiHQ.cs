using System;
using System.Collections.Generic;

namespace MaxibonKataCSharp
{
    public class KarumiHQ
    {
        readonly IChat chat;
        int maxibonsLeft;

        public int MaxibonsLeft
        {
            get
            {
                return maxibonsLeft;
            }
        }

        bool ShouldBuyMoreMaxibons => maxibonsLeft <= 2;

        public KarumiHQ(IChat chat)
        {
            this.chat = chat;
            maxibonsLeft = 10;
        }

        public KarumiHQ() : this(new Slack())
        {
        }

        public void OpenFridge(Developer developer)
        {
            OpenFridge(new List<Developer>() { developer });
        }

        void OpenFridge(List<Developer> developers)
        {
            developers.ForEach(developer =>
            {
                GrabMaxibons(developer);
                if (ShouldBuyMoreMaxibons)
                {
                    NotifyWeShouldBuyMaxibons(developer);
                    BuyMoreMaxibons();
                }
            });
        }

        private void BuyMoreMaxibons()
        {
            maxibonsLeft += 10;
        }

        private void NotifyWeShouldBuyMaxibons(Developer developer)
        {
            var message = $"Hi guys, I'm {developer}. We need more maxibons!";
            chat.Send(message: message);
        }

        private void GrabMaxibons(Developer developer)
        {
            maxibonsLeft -= developer.NumberOfMaxibonsToGet;
            if (maxibonsLeft < 0)
            {
                maxibonsLeft = 0;
            }
        }
    }
}