using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nome.LDAP.Connection.Interfaces;

namespace Nome.LDAP.Connection
{
    public class ActiveDirectory : ConnectionBase, IConnection
    {
        private static ActiveDirectory _instance;

        public static ActiveDirectory Instanec
        {
            get
            {
                return _instance;
            }
        }

        public ActiveDirectory(string host) : base(host)
        {
            _instance = new ActiveDirectory(host);
            this.DirectoryEntry.AuthenticationType = System.DirectoryServices.AuthenticationTypes.Secure;

            try
            {
                var x = this.EstablishConnection();
            }
            catch
            {

            }
        }


    }
}
