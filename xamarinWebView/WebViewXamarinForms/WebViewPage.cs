using System;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;


namespace WebViewXamarinForms
{
	public class WebViewPage : ContentPage
	{
        public WebView browser;
		public WebViewPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);

            Label lbl_header = new Label
            {
                Text = "WebView",
                HorizontalOptions = LayoutOptions.Center
            };
            //WebView webview = new WebView
            //{
            //    Source = new UrlWebViewSource { Url = "file:///android_asset/www/login.html" }, //"http://google.com",
            //    VerticalOptions = LayoutOptions.FillAndExpand

            //};

            //this.Content = new StackLayout
            //{
            //    Children = {
            //         webview
            //    }
            //};
            //-----------------------------------------------------------
            //            var browser = new WebView();

            //            var htmlSource = new HtmlWebViewSource();

            //            htmlSource.Html = @"<html><body>
            //<h1>Xamarin.Forms</h1>
            //<p>Welcome to WebView.</p>
            //</body>
            //</html>";


            //            browser.Source = htmlSource;

            //            Content = browser;

            //-----------------------------------------------------
            //var source = new HtmlWebViewSource();
            //source.BaseUrl = DependencyService.Get<IBaseUrl>().Get();


            browser = new WebView();
            var htmlSource = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;
            Content = browser;
        }

        protected override bool OnBackButtonPressed()
        {
            browser.GoBack();

            return true;
        }

    }
}


