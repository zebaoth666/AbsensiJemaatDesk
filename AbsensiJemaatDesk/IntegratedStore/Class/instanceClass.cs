using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsensiJemaatDesk
{
    public class instanceClass
    {
        public static frmMenu menu = new frmMenu();
        public static frmLogin log = new frmLogin();
        public static frmPassword pass = new frmPassword();
        public static frmUser user = new frmUser();
        public static frmUmat jem = new frmUmat();
        public static frmPD bakti = new frmPD();
        public static rptPD rptPD = new rptPD();
        public static rptBirthday rptBirth = new rptBirthday();
        public static rptGraph rptGraph = new rptGraph();
    }
}