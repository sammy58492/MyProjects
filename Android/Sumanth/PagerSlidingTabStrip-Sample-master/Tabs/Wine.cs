using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tabs
{
    public class Wine
    {
        public string Name { get; set; }
        public string Vintage { get; set; }

        public string Price { get; set; }
        public string imageURL { get; set; }
        public string SKU { get; set; }
        public string Ratings { get; set; }
        public string UserRatings { get; set; }
    }
}