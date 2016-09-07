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
            this.DirectoryEntry.AuthenticationType = System.DirectoryServices.AuthenticationTypes.Secure;
            try
            {
                var result = this.EstablishConnection();
                if (!result.First().Key)
                {
                    this.DirectoryEntry.Dispose();

                    //Retry to connect a LDAP server.
                    //TODO : Entry need information using by some way.
                    this.DirectoryEntry = new System.DirectoryServices.DirectoryEntry(this.Host, "username", "password");
                    var secondalyResult = this.EstablishConnection();
                    if (!secondalyResult.First().Key)
                    {
                        this.DirectoryEntry.Dispose();
                    }
                }
            }
            finally
            {
                _instance = this;
            }
        }
    }
}
