//using System;
//using Xamarin.Forms;

//namespace WebViewXamarinForms.Droid
//{
//    class BaseUrl_Android
//    {
//    }
//}


using System;
using Xamarin.Forms;
using WorkingWithWebview.Android;
using WebViewXamarinForms;

[assembly: Dependency (typeof (BaseUrl_Android))]
namespace WorkingWithWebview.Android
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/www/index.html";
        }
    }
}