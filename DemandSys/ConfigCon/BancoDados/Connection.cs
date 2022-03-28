using System.Data.Common;

namespace DemandSys.CODE
{
    public class Connection
    {
        public static DbTransaction Transaction { get; set; }
        public static DbCommand DbCommand { get; set; }
    }
}
