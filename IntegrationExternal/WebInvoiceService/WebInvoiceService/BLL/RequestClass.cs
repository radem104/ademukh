using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebInvoiceService.BLL
{
    public class RequestClass
    {
        private string serviceHost;
        private string authServiceUrl;
        private string userName;
        private string userPassword;
        private CookieContainer _authCookie;
        public string SelectRequest(string json)
        {
            string responseMessage = "";
            if (TryLogin())
            {
                
                authServiceUrl = serviceHost + @"/0/dataservice/json/reply/SelectQuery";
                var request = CreateRequest(authServiceUrl, json);
  
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            responseMessage = reader.ReadToEnd();
                            
                        }
                    }
                }
            }
            return responseMessage;
        }

        public string InsertRequest(string json)
        {
            string responseMessage = "";

            authServiceUrl = serviceHost + @"/0/dataservice/json/reply/InsertQuery";
            var request = CreateRequest(authServiceUrl, json);

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseMessage = reader.ReadToEnd();
                    }
                }
            }
            return responseMessage;
        }
        public bool TryLogin()
        {
            serviceHost = System.Configuration.ConfigurationManager.AppSettings["serviceHost"];
            userName = System.Configuration.ConfigurationManager.AppSettings["userName"];
            userPassword = System.Configuration.ConfigurationManager.AppSettings["userPassword"];
            var authData = @"{
                ""UserName"":""" + userName + @""",
                ""UserPassword"":""" + userPassword + @"""
            }";
            authServiceUrl = serviceHost + @"/ServiceModel/AuthService.svc/Login";
            
            _authCookie = new CookieContainer();
            var request = CreateRequest(authServiceUrl, authData);
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        var responseMessage = reader.ReadToEnd();
                        Console.WriteLine(responseMessage);
                        if (responseMessage.Contains("\"Code\":1"))
                        {
                            throw new UnauthorizedAccessException($"Unauthorized {userName} for {serviceHost}");
                        }
                    }
                    string authName = ".ASPXAUTH";
                    string authCookeValue = response.Cookies[authName].Value;
                    _authCookie.Add(new Uri(serviceHost), new Cookie(authName, authCookeValue));
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
            private HttpWebRequest CreateRequest(string url, string requestData = null)
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json";
                request.Method = "POST";
                request.KeepAlive = true;
                request.CookieContainer = _authCookie;
                if (!string.IsNullOrEmpty(requestData))
                {
                    using (var requestStream = request.GetRequestStream())
                    {
                        using (var writer = new StreamWriter(requestStream))
                        {
                            writer.Write(requestData);
                        }
                    }
                }
                AddCsrfToken(request);
                return request;
            }

        private void AddCsrfToken(HttpWebRequest request)
        {
            var cookie = _authCookie.GetCookies(new Uri(serviceHost))["BPMCSRF"];
            if (cookie != null)
            {
                request.Headers.Add("BPMCSRF", cookie.Value);
            }
        }
    }
    }