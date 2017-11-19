using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBO;

namespace MDAL
{
    public class mdalclass
    {
        public int addasv(asvbo a)
        {
            try
            {
                using (var db = new asvcontext())
                {
                    PD3ASV tbl = new PD3ASV();
                    tbl.PhoneNumber = a.PhoneNumber;
                    tbl.AsvId = a.AsvId;
                    tbl.Address = a.Address;
                    tbl.AsvName = a.AsvName;
                    tbl.EmailId = a.EmailId;
                    tbl.Country = a.Country;
                    tbl.Region = a.Region;
                    tbl.CompetencyLevel = a.CompetencyLevel;
                    db.PD3ASV.Add(tbl);
                    db.SaveChanges();
                    return 1;

                }
            }
            catch
            {
                return 0;
            }
        }
        public asvbo exchg(PD3ASV pp)
        {
            asvbo bo = new asvbo();
            bo.AsvId = pp.AsvId;
            bo.PhoneNumber = pp.PhoneNumber;
            bo.Address = pp.Address;
            bo.AsvName = pp.AsvName;
            bo.EmailId = pp.EmailId;
            bo.Country = pp.Country;
            bo.Region = pp.Region;
            bo.CompetencyLevel = pp.CompetencyLevel;
            return bo;


        }
        public List<asvbo> pick(asvview jj)
        {
            List<asvbo> lst = new List<asvbo>();
            List<asvbo> ctlst = new List<asvbo>() { };
            try
            {
                using (var db = new asvcontext())
                {

                    if (jj.AsvId != 0)
                    {
                        asvbo bo = new asvbo();
                        PD3ASV tbl = db.PD3ASV.Single(p => p.AsvId == jj.AsvId);
                        bo = exchg(tbl);
                        //bo.AsvId = tbl.AsvId;
                        //bo.PhoneNumber = tbl.PhoneNumber;
                        //bo.Address = tbl.Address;
                        //bo.AsvName = tbl.AsvName;
                        //bo.EmailId = tbl.EmailId;
                        //bo.Country = tbl.Country;
                        //bo.Region = tbl.Region;
                        //bo.CompetencyLevel = tbl.CompetencyLevel;
                        lst.Add(bo);
                        return lst;
                    }
                    else
                    {

                        if (!(string.IsNullOrEmpty((jj.Region))) && string.IsNullOrEmpty((jj.CompetencyLevel)))
                        {
                            List<PD3ASV> tlst = db.PD3ASV.ToList();


                            foreach (PD3ASV pp in tlst)
                            {
                                asvbo bo = new asvbo();
                                if (pp.Region == jj.Region)
                                {
                                    bo = exchg(pp);
                                    //bo.AsvId = pp.AsvId;
                                    //bo.PhoneNumber = pp.PhoneNumber;
                                    //bo.Address = pp.Address;
                                    //bo.AsvName = pp.AsvName;
                                    //bo.EmailId = pp.EmailId;
                                    //bo.Country = pp.Country;
                                    //bo.Region = pp.Region;
                                    //bo.CompetencyLevel = pp.CompetencyLevel;
                                    lst.Add(bo);


                                }


                            }
                            return lst;
                        }
                        else if (!(string.IsNullOrEmpty((jj.CompetencyLevel))) && string.IsNullOrEmpty((jj.Region)))
                        {

                            List<PD3ASV> tlst = db.PD3ASV.ToList();
                            foreach (PD3ASV pp in tlst)
                            {
                                asvbo bo = new asvbo();
                                if (pp.CompetencyLevel == jj.CompetencyLevel)
                                {
                                    bo = exchg(pp);
                                    //bo.AsvId = pp.AsvId;
                                    //bo.PhoneNumber = pp.PhoneNumber;
                                    //bo.Address = pp.Address;
                                    //bo.AsvName = pp.AsvName;
                                    //bo.EmailId = pp.EmailId;
                                    //bo.Country = pp.Country;
                                    //bo.Region = pp.Region;
                                    //bo.CompetencyLevel = pp.CompetencyLevel;
                                    lst.Add(bo);


                                }


                            }
                            return lst;
                        }
                        else
                        {

                            List<PD3ASV> tlst = db.PD3ASV.ToList();
                            List<PD3ASV> ab = db.PD3ASV.Where((x => x.CompetencyLevel == jj.CompetencyLevel && x.Region == jj.Region)).ToList();
                            foreach (PD3ASV pp in ab)
                            {
                                asvbo bo = new asvbo();
                                // if ((pp.CompetencyLevel == jj.CompetencyLevel) && (pp.Region == jj.Region))
                                {
                                    bo = exchg(pp);
                                    //bo.AsvId = pp.AsvId;
                                    //bo.PhoneNumber = pp.PhoneNumber;
                                    //bo.Address = pp.Address;
                                    //bo.AsvName = pp.AsvName;
                                    //bo.EmailId = pp.EmailId;
                                    //bo.Country = pp.Country;
                                    //bo.Region = pp.Region;
                                    //bo.CompetencyLevel = pp.CompetencyLevel;
                                    lst.Add(bo);


                                }


                            }
                            return lst;
                        }

                    }
                }
            }
            catch
            {
                return ctlst;
            }

        }
        public asvbo prdetails(int id)
        {
            using (var db = new asvcontext())
            {
                PD3ASV ss = db.PD3ASV.Single(x => x.AsvId == id);
                asvbo bo = new asvbo();
                bo = exchg(ss);
                //bo.AsvId = ss.AsvId;
                //bo.PhoneNumber = ss.PhoneNumber;
                //bo.Address = ss.Address;
                //bo.AsvName = ss.AsvName;
                //bo.EmailId = ss.EmailId;
                //bo.Country = ss.Country;
                //bo.Region = ss.Region;
                //bo.CompetencyLevel = ss.CompetencyLevel;
                return (bo);

            }
        }
        public void updt(int id, asvbo bo)
        {
            using (var db = new asvcontext())
            {
                PD3ASV ss = db.PD3ASV.Single(x => x.AsvId == id);

                ss.PhoneNumber = bo.PhoneNumber;
                ss.Address = bo.Address;
                ss.AsvName = bo.AsvName;
                ss.EmailId = bo.EmailId;
                ss.Country = bo.Country;
                ss.Region = bo.Region;
                ss.CompetencyLevel = bo.CompetencyLevel;
                db.SaveChanges();
            }

        }
        public void dlt(int id)
        {
            using (var db = new asvcontext())
            {
                PD3ASV ss = db.PD3ASV.Single(x => x.AsvId == id);
                db.PD3ASV.Remove(ss);
                db.SaveChanges();

            }

        }
        public int seeclaim()
        {

            DateTime dt = DateTime.Now;
            DateTime yesterday = dt.AddDays(-1);
            int i = 0;
            using (var db = new asvcontext())
            {
                List<PD3CLAIM> clst = db.PD3CLAIM.ToList();
                foreach (PD3CLAIM ob in clst)

                {
                    if ((ob.ClaimUpdateDate == yesterday.Date))//&&(ob.ClaimUpdateDate<=dt.Date))

                    {
                        i = i + 1;

                    }

                }
                return i;
            }
        }
        public int seedevice()
        {
            int i = 0;
            using (var db = new asvcontext())
            {
                List<PD3DEVICE1> plst = db.PD3DEVICE1.ToList();
                foreach (PD3DEVICE1 ll in plst)
                {
                    i = i + 1;
                }
                return i;
            }
        }
        public int[] viewregion()
        {
            int[] arr = new int[5];
            using (var db = new asvcontext())
            {
                List<PD3ASV> tbl = db.PD3ASV.ToList();
                foreach (PD3ASV ot in tbl)
                {
                    if (ot.Region == "Americas")
                    {
                        arr[0] = arr[0] + 1;
                    }
                    else if (ot.Region == "EMEA")
                    {
                        arr[1] = arr[1] + 1;
                    }
                    else if (ot.Region == "APAC")
                    {
                        arr[2] = arr[2] + 1;
                    }
                    else if (ot.Region == "China")
                    {
                        arr[3] = arr[3] + 1;
                    }

                }
                return arr;
            }
        }
    }

}
