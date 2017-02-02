using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikolaKretenStart
{
    public static class ExtensionMethods
    {
        public static string GetRoleName(this RoleType roleType)
        {
            switch (roleType)
            {
                case RoleType.CTO:
                    return "CTO";
                case RoleType.COO:
                    return "COO";
                case RoleType.CEO:
                    return "CEO";
                case RoleType.CopyPaste:
                    return "Copy-Paste";
                case RoleType.Developer:
                    return "Software Developer";
                default:
                    return "unknown role";

            }
        }

        public static string GetDepartmanName(this DepartmanType departmanType)
        {
            switch (departmanType)
            {
                case DepartmanType.JS:
                    return "JS/JAVA";
                case DepartmanType.PHP:
                    return "PHP";
                case DepartmanType.DNET:
                    return ".NET";
                case DepartmanType.Internal:
                    return "Internal Projects";
                case DepartmanType.QA:
                    return "QA";
                case DepartmanType.HR:
                    return "HR";
                default:
                    return "unknown departman";

            }
        }

    }
}
