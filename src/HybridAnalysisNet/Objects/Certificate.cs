using System;
using System.Collections.Generic;
using System.Text;

namespace HybridAnalysisNet.Objects
{
    class Certificate
    {
        owner string
            issuer  string
            serial_number   string
            md5 string
            sha1    string
            valid_from  string ($date-time)
        valid_until string ($date-time)
    }
}
