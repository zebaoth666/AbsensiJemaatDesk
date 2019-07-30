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
        public static frmKoneksi konek = new frmKoneksi(false);
        public static frmUser user = new frmUser();
        public static frmSetup setup = new frmSetup();
        public static frmJemaat jem = new frmJemaat();
        public static frmKebaktian bakti = new frmKebaktian();
    }
}