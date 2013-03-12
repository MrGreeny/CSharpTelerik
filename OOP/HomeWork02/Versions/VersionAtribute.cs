using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Versions
{
    [AttributeUsage(AttributeTargets.Struct |AttributeTargets.Class
        |AttributeTargets.Interface |AttributeTargets.Enum 
        | AttributeTargets.Method) ]
    public class VersionAttribute : Attribute
    {
        private string major;
        private string minor;
        private string version;
        private string comment;

        public string Version {
            get
            {
                return version;
            }
        }

        public VersionAttribute(string ver)
        {
            //Splits the string 
            string[] versionArr = ver.Split('.');
            //Asigns the first string to the major version
            this.major = versionArr[0];

            //assigns the rest of the string to the minor part of the version
            minor = "";
            for (int i = 1; i < versionArr.Length; i++)
            {
                minor += string.Format("{0}.", versionArr[i]);
            }
            this.version = string.Format("{0}.{1}", major, minor);
        }
    }
}
