using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDialog.View;

namespace WpfDialog.ViewResource
{
    public class ViewResourceDictionary
    {
        public static Dictionary<string, string> stringViewResource
            = new Dictionary<string, string>() { 
                { "Title", "Page1Title!" },
                { "SubTitle", "Page1SubTitle!" }, };
    }
}
