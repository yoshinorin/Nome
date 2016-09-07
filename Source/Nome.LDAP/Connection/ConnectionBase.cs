using System;
using System.Collections.Generic;
using System.DirectoryServices;

/// <summary>
/// Provide function of LDAP server connection.
/// </summary>
namespace Nome.LDAP.Connection
{
    /// <summary>
    /// LDAP server connection base class.
    /// </summary>
    public class ConnectionBase
    {
        public System.DirectoryServices.DirectoryEntry DirectoryEntry { get; protected set; } = new System.DirectoryServices.DirectoryEntry();

        /// <summary>
        /// Result of confirm connection.
        /// </summary>
        private Dictionary<bool, string> result = new Dictionary<bool, string>();

        /// <summary>
        /// LDAP server's url.
        /// </summary>
        public string Host { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host">LDAP host.</param>
        public ConnectionBase(string host)
        {
            this.Host = host;
            this.DirectoryEntry.Path = this.Host;
        }

        /// <summary>
        /// Confirm connection.
        /// </summary>
        protected Dictionary<bool, string> EstablishConnection()
        {
            try
            {
                var x = DirectoryEntry.NativeObject;
                result.Add(true, "success");
                return result;
            }
            catch(Exception ex)
            {
                result.Add(false, ex.Message);
                return result;
            }
            finally
            {
                DirectoryEntry.Dispose();
            }
        }
    }
}
