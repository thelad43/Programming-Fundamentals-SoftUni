namespace _01.Anonymous_Downsite
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var securityKey = int.Parse(Console.ReadLine());
            var websites = ReadWebsites(n);

            PrintResult(securityKey, websites);
        }

        private static void PrintResult(int securityKey, List<WebSite> websites)
        {
            var totalLoss = 0M;

            foreach (var website in websites)
            {
                Console.WriteLine(website.Name);
                totalLoss += website.SiteLoss;
            }

            var securityToken = BigInteger.Pow(securityKey, websites.Count);

            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }

        private static List<WebSite> ReadWebsites(int n)
        {
            var websites = new List<WebSite>(n);

            for (int i = 0; i < n; i++)
            {
                var website = ReadWebsite(n);
                websites.Add(website);
            }

            return websites;
        }

        private static WebSite ReadWebsite(int n)
        {
            var siteParameters = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var siteName = siteParameters[0];
            var siteVisits = long.Parse(siteParameters[1]);
            var siteCommercialPricePerVisit = decimal.Parse(siteParameters[2]);
            var siteLoss = siteVisits * siteCommercialPricePerVisit;

            return new WebSite(siteName, siteVisits, siteCommercialPricePerVisit, siteLoss);
        }
    }

    public class WebSite
    {
        private string name;
        private decimal siteVisits;
        private decimal siteCommercialPricePerVisit;
        private decimal siteLoss;

        public WebSite(string name, decimal siteVisits, decimal siteCommercialPricePerVisit, decimal siteLoss)
        {
            this.Name = name;
            this.SiteVisits = siteVisits;
            this.SiteCommercialPricePerVisit = siteCommercialPricePerVisit;
            this.SiteLoss = siteLoss;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public decimal SiteVisits
        {
            get
            {
                return this.siteVisits;
            }
            private set
            {
                this.siteVisits = value;
            }
        }

        public decimal SiteCommercialPricePerVisit
        {
            get
            {
                return this.siteCommercialPricePerVisit;
            }
            private set
            {
                this.siteCommercialPricePerVisit = value;
            }
        }

        public decimal SiteLoss
        {
            get
            {
                return this.siteLoss;
            }
            private set
            {
                this.siteLoss = value;
            }
        }
    }
}