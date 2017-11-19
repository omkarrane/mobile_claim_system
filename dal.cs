using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dal
    {
        public int add(bo ob)
        {
            int i;
            try
            {
                PD3DEVICE2 oc = new PD3DEVICE2();
                oc.DEVICE_NAME = ob.DEVICE_NAME;
                oc.DEVICE_TYPE = ob.DEVICE_TYPE;
                oc.IMEI_NUMBER = ob.IMEI_NUMBER;
                oc.DATEOFMANUFACTURING = ob.DATEOFMANUFACTURING;
                oc.DATEOFSHIPPING = ob.DATEOFSHIPPING;
                oc.DATEOFWARRENTYEXPIRY = ob.DATEOFWARRENTYEXPIRY;
                oc.INWARRENTY = ob.INWARRENTY;
                oc.PRICE = ob.PRICE;
                using (var db = new Model1())
                {
                    db.PD3DEVICE2.Add(oc);
                    db.SaveChanges();


                }
                return i = 1;
            }
            catch (Exception ex)
            {


                return i = 0;
            }
        }


        public void updat(bo c, int id)
        {
            using (var db = new Model1())
            {
                PD3DEVICE2 s = db.PD3DEVICE2.FirstOrDefault(x => x.DEVICEID == id);
                s.DEVICE_NAME = c.DEVICE_NAME;
                s.DEVICE_TYPE = c.DEVICE_TYPE;
                s.IMEI_NUMBER = c.IMEI_NUMBER;
                s.DATEOFMANUFACTURING = c.DATEOFMANUFACTURING;
                s.DATEOFSHIPPING = c.DATEOFSHIPPING;
                s.DATEOFWARRENTYEXPIRY = c.DATEOFWARRENTYEXPIRY;
                s.INWARRENTY = c.INWARRENTY;
                s.PRICE = c.PRICE;
                db.SaveChanges();
            }

        }
        public bo getdetails(int id)
        {
            using (var db = new Model1())
            {
                PD3DEVICE2 s = db.PD3DEVICE2.Single(x => x.DEVICEID == id);
                bo c = new bo();
                c.DEVICE_NAME = s.DEVICE_NAME;
                c.DEVICE_TYPE = s.DEVICE_TYPE;
                c.IMEI_NUMBER = s.IMEI_NUMBER;
                c.DATEOFMANUFACTURING = s.DATEOFMANUFACTURING;
                c.DATEOFSHIPPING = s.DATEOFSHIPPING;
                c.DATEOFWARRENTYEXPIRY = s.DATEOFWARRENTYEXPIRY;
                c.INWARRENTY = s.INWARRENTY;
                c.PRICE = s.PRICE;
                return c;
            }

        }
        public List<bo> view1()
        {
            List<bo> a = new List<bo>();

            using (var db = new Model1())
            {
                List<PD3DEVICE2> b = db.PD3DEVICE2.ToList();
                foreach (PD3DEVICE2 c in b)
                {
                    bo ac = new bo();
                    ac.DEVICEID = c.DEVICEID;
                    ac.DEVICE_NAME = c.DEVICE_NAME;
                    ac.DEVICE_TYPE = c.DEVICE_TYPE;
                    ac.IMEI_NUMBER = c.IMEI_NUMBER;
                    ac.DATEOFMANUFACTURING = c.DATEOFMANUFACTURING;
                    ac.DATEOFSHIPPING = c.DATEOFSHIPPING;
                    ac.DATEOFWARRENTYEXPIRY = c.DATEOFWARRENTYEXPIRY;
                    ac.INWARRENTY = c.INWARRENTY;
                    ac.PRICE = c.PRICE;
                    a.Add(ac);
                    db.SaveChanges();

                }
                return (a);
            }

        }
        public List<bo> viewbyid(int id)
        {



            PD3DEVICE2 objtbl;

            List<PD3DEVICE2> lst = new List<PD3DEVICE2>();
            List<bo> lstbo = new List<bo>();

            try
            {
                using (var db = new Model1())
                {
                    objtbl = db.PD3DEVICE2.First(e => e.DEVICEID == id);

                    lst.Add(objtbl);
                }

                foreach (PD3DEVICE2 objse in lst)
                {
                    bo objbo = new bo();
                    objbo.DEVICEID = objse.DEVICEID;
                    objbo.DEVICE_NAME = objse.DEVICE_NAME;
                    objbo.DEVICE_TYPE = objse.DEVICE_TYPE;
                    objbo.IMEI_NUMBER = objse.IMEI_NUMBER;
                    objbo.DATEOFMANUFACTURING = objse.DATEOFMANUFACTURING;
                    objbo.DATEOFSHIPPING = objse.DATEOFSHIPPING;
                    objbo.DATEOFWARRENTYEXPIRY = objse.DATEOFWARRENTYEXPIRY;
                    objbo.INWARRENTY = objse.INWARRENTY;
                    objbo.PRICE = objse.PRICE;
                    lstbo.Add(objbo);
                }
            }
            catch (Exception ex)
            {

            }

            return lstbo;
        }
        public List<bo> viewbyimei(long ime)
        {



            PD3DEVICE2 objtbl;

            List<PD3DEVICE2> lst = new List<PD3DEVICE2>();
            List<bo> lstbo = new List<bo>();

            try
            {
                using (var db = new Model1())
                {
                    objtbl = db.PD3DEVICE2.First(e => e.IMEI_NUMBER == ime);

                    lst.Add(objtbl);
                }

                foreach (PD3DEVICE2 objse in lst)
                {
                    bo objbo = new bo();
                    objbo.DEVICEID = objse.DEVICEID;
                    objbo.DEVICE_NAME = objse.DEVICE_NAME;
                    objbo.DEVICE_TYPE = objse.DEVICE_TYPE;
                    objbo.IMEI_NUMBER = objse.IMEI_NUMBER;
                    objbo.DATEOFMANUFACTURING = objse.DATEOFMANUFACTURING;
                    objbo.DATEOFSHIPPING = objse.DATEOFSHIPPING;
                    objbo.DATEOFWARRENTYEXPIRY = objse.DATEOFWARRENTYEXPIRY;
                    objbo.INWARRENTY = objse.INWARRENTY;
                    objbo.PRICE = objse.PRICE;
                    lstbo.Add(objbo);
                }
            }
            catch (Exception ex)
            {

            }

            return lstbo;
        }
        public List<bo> viewbyman(DateTime date)
        {



            PD3DEVICE2 objtbl;

            List<PD3DEVICE2> lst = new List<PD3DEVICE2>();
            List<bo> lstbo = new List<bo>();

            try
            {
                using (var db = new Model1())
                {
                    objtbl = db.PD3DEVICE2.First(e => e.DATEOFMANUFACTURING == date);

                    lst.Add(objtbl);
                }

                foreach (PD3DEVICE2 objse in lst)
                {
                    bo objbo = new bo();
                    objbo.DEVICEID = objse.DEVICEID;
                    objbo.DEVICE_NAME = objse.DEVICE_NAME;
                    objbo.DEVICE_TYPE = objse.DEVICE_TYPE;
                    objbo.IMEI_NUMBER = objse.IMEI_NUMBER;
                    objbo.DATEOFMANUFACTURING = objse.DATEOFMANUFACTURING;
                    objbo.DATEOFSHIPPING = objse.DATEOFSHIPPING;
                    objbo.DATEOFWARRENTYEXPIRY = objse.DATEOFWARRENTYEXPIRY;
                    objbo.INWARRENTY = objse.INWARRENTY;
                    objbo.PRICE = objse.PRICE;
                    lstbo.Add(objbo);
                }
            }
            catch (Exception ex)
            {

            }

            return lstbo;
        }
        public List<bo> viewbyship(DateTime date1)
        {



            PD3DEVICE2 objtbl;

            List<PD3DEVICE2> lst = new List<PD3DEVICE2>();
            List<bo> lstbo = new List<bo>();

            try
            {
                using (var db = new Model1())
                {
                    objtbl = db.PD3DEVICE2.First(e => e.DATEOFSHIPPING == date1);

                    lst.Add(objtbl);
                }

                foreach (PD3DEVICE2 objse in lst)
                {
                    bo objbo = new bo();
                    objbo.DEVICEID = objse.DEVICEID;
                    objbo.DEVICE_NAME = objse.DEVICE_NAME;
                    objbo.DEVICE_TYPE = objse.DEVICE_TYPE;
                    objbo.IMEI_NUMBER = objse.IMEI_NUMBER;
                    objbo.DATEOFMANUFACTURING = objse.DATEOFMANUFACTURING;
                    objbo.DATEOFSHIPPING = objse.DATEOFSHIPPING;
                    objbo.DATEOFWARRENTYEXPIRY = objse.DATEOFWARRENTYEXPIRY;
                    objbo.INWARRENTY = objse.INWARRENTY;
                    objbo.PRICE = objse.PRICE;
                    lstbo.Add(objbo);
                }
            }
            catch (Exception ex)
            {

            }

            return lstbo;
        }
    }
}

