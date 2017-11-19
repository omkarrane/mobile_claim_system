using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class bll
    {
        public int add(bo ob)
        {
            dal objdal = new dal();

            return objdal.add(ob);
        }
        public void updat(bo c, int id)
        {
            dal dd = new dal();
            dd.updat(c, id);

        }
        public bo getdetails(int id)
        {
            dal dd = new dal();
            bo r = dd.getdetails(id);
            return r;
        }
        public List<bo> viewdet()
        {
            dal objdal = new dal();
            return objdal.view1();
        }
        public List<bo> viewbyid(bo id)
        {
            dal objdal = new dal();

            return objdal.viewbyid(id.DEVICEID);
        }
        public List<bo> viewbyimei(long ime)
        {
            dal objdal = new dal();

            return objdal.viewbyimei(ime);
        }
        public List<bo> viewbyman(DateTime date)
        {
            dal objdal = new dal();

            return objdal.viewbyman(date);
        }
        public List<bo> viewbyship(DateTime date1)
        {
            dal objdal = new dal();

            return objdal.viewbyship(date1);
        }

    }
}
