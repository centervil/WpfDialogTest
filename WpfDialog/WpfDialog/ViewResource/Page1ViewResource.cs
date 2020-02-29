using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDialog.ViewResource
{
    class Page1ViewResource : ViewResourceBase
    {
        private static string title = "Page1Title";
        private static string subTitle = "Page1SubTitle";
        private static string description = "This is Page1";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
        public string SubTitle
        {
            get { return subTitle; }
            set { SetProperty(ref subTitle, value); }
        }
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }
    }
}
