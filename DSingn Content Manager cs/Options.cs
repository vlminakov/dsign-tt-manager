using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace DSingn_Content_Manager_cs
{
    public sealed class Options
    {
        private static volatile Options instanse;
        private static object syncRoot = new Object();

        private string uuid;

        public string Uuid
        {
            get { return uuid; }
            set { uuid = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private KeyValuePair<string, string> cookies;

        public KeyValuePair<string, string> Cookies
        {
            get { return cookies; }
            set
            {
                cookies = new KeyValuePair<string, string>("Cookie:", value.ToString());
            }
        }

        private Options()
        {
            this.uuid = null;
            this.email = "";
            this.password = "";
            this.cookies = new KeyValuePair<string, string>("Cookie:", "");
        }

        public static Options Instance
        {
            get
            {
                if (instanse == null)
                {
                    lock(syncRoot)
                    {
                        if (instanse == null)
                        {
                            instanse = new Options();
                        }
                    }
                }
                return instanse;
            }
        }
    }
}
