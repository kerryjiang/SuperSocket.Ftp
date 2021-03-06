using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSocket.Ftp.FtpService.Membership
{
    /// <summary>
    /// Anonymous ftp user
    /// </summary>
    public class Anonymous : FtpUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Anonymous"/> class.
        /// </summary>
        public Anonymous()
        {
            this.UserName = "anonymous";
            this.MaxConnections = 2;
        }
    }
}
