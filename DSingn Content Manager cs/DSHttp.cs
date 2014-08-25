using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net    ;
using System.IO;
using System.Diagnostics;

namespace DSingn_Content_Manager_cs
{
    public sealed class DSHttp
    {
        private static volatile DSHttp instance;
        private static object syncRoot = new Object();
        private string[] cookies = new string[]{};

        //private HttpClient httpClient;

        private DSHttp()
        {
        }

        public static DSHttp Instance
        {
            get 
            {
                if (instance == null) 
                {
                    lock (syncRoot) 
                    {
                        if (instance == null)
                            instance = new DSHttp();
                    }
                }
                return instance;
             }
        }

        public string queryServer(int method, string path, KeyValuePair<string, string>[] headers, KeyValuePair<string, string>[] data, string dataStr)
        {
            using (WebClient wc = new WebClient())
            {
                if (cookies.Length > 0)
                {
                    string hdrStr = "";
                    foreach (string str in cookies)
                    {
                        hdrStr += str + ";";
                    }
                    WebHeaderCollection whc = new WebHeaderCollection();
                    whc.Add(HttpRequestHeader.Cookie, cookies[1]);
                    wc.Headers.Add(whc);
                }
                if (headers != null && headers.Length > 0)
                {
                    foreach (KeyValuePair<string, string> kvp in headers)
                    {
                        wc.Headers.Add(kvp.Key, kvp.Value);
                    }
                }
                if (method == Constants.HTTP_METHOD_POST)
                {
                    string dataString = "";
                    if (data != null && data.Length > 0)
                    {
                        foreach (KeyValuePair<string, string> kvp in data)
                        {
                            dataString += kvp.Key + "=" + kvp.Value + "&";
                        }
                    }
                    if (dataStr != null && dataStr.Length > 0)
                    {
                        dataString = dataStr;
                    }
                    string result = wc.UploadString(Constants.HTTP_BASE_URL + path, "Post", dataString);

                    if (this.cookies.Length == 0)
                    {
                        WebHeaderCollection respHeaders = wc.ResponseHeaders;
                        for (int i = 0; i < respHeaders.Count; i++)
                        {
                            if (respHeaders.GetKey(i).Equals("Set-Cookie"))
                            {
                                this.cookies = respHeaders.GetValues(i);
                            }
                        }
                    }
                    
                    return result;
                }
                else if (method == Constants.HTTP_METHOD_GET)
                {
                    string dataString = "";
                    if (data != null && data.Length > 0)
                    {
                        dataString += "?";
                        foreach (KeyValuePair<string, string> kvp in data)
                        {
                            dataString += kvp.Key + "=" + kvp.Value + "&";
                        }
                    }
                    string result = wc.DownloadString(Constants.HTTP_BASE_URL + path + dataString);

                    if (this.cookies.Length == 0)
                    {
                        WebHeaderCollection respHeaders = wc.ResponseHeaders;
                        for (int i = 0; i < respHeaders.Count; i++)
                        {
                            if (respHeaders.GetKey(i).Equals("Set-Cookie"))
                            {
                                this.cookies = respHeaders.GetValues(i);
                            }
                        }
                    }

                    return result;
                }
            }

            return "";
        }
    }
}
