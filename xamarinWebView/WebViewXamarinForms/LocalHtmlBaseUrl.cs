﻿
using System;
using Xamarin.Forms;

namespace WebViewXamarinForms
{

    public interface IBaseUrl { string Get(); }

    // required temporarily for iOS, due to BaseUrl bug
    public class BaseUrlWebView : WebView { }

    public class LocalHtmlBaseUrl : ContentPage
    {
        public LocalHtmlBaseUrl()
        {
            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS

            var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<html>
<head>
<link rel=""stylesheet"" href=""default.css"">
</head>
<body>
<h1>Xamarin.Forms</h1>
<p>The CSS and image are loaded from local files!</p>
<img src='XamarinLogo.png'/>
<p><a href=""login.html"">next page</a></p>
</body>
</html>";

            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();


            browser.Source = htmlSource;

            Content = browser;
        }
    }
}


