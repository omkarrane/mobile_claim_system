using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDAL;
using JBO;

namespace JDAL
{
    public class RCMDal
    {
        public int RCMdetails(RCMBo NewRcmBo)
        {
            PD3RCM NewRcmTable = new PD3RCM();

            //try
            {
                NewRcmTable.RCM_NAME = NewRcmBo.Name;
                NewRcmTable.DATEOFJOINING = NewRcmBo.DateOfJoining;
                NewRcmTable.EMAILID = NewRcmBo.Email;
                NewRcmTable.REGION = NewRcmBo.Region;
                NewRcmTable.COUNTRY = NewRcmBo.Country;
                NewRcmTable.ADDRESS = NewRcmBo.Address;



                using (var dbContext = new Model2())
                {
                    dbContext.PD3RCM.Add(NewRcmTable);
                    dbContext.SaveChanges();
                }
            }
            //catch (Exception ex)
            //{
            //    Console.Write(ex.Message);
            //}
            return NewRcmTable.RCMID;
        }


        public List<RCMBo> ViewRcmById(int rcmid)
        {
            List<PD3RCM> RcmTableList = new List<PD3RCM>();
            List<RCMBo> RcmBoList = new List<RCMBo>();

            try
            {
                using (var dbContext = new Model2())
                {
                    RcmTableList = dbContext.PD3RCM.Where(r => r.RCMID == rcmid).ToList<PD3RCM>();
                }

                foreach (PD3RCM RcmTable in RcmTableList)
                {
                    RCMBo newRCMBo = new RCMBo();
                    newRCMBo.RcmId = RcmTable.RCMID;
                    newRCMBo.Name = RcmTable.RCM_NAME;
                    newRCMBo.DateOfJoining = RcmTable.DATEOFJOINING;
                    newRCMBo.Email = RcmTable.EMAILID;
                    newRCMBo.Region = RcmTable.REGION;
                    newRCMBo.Country = RcmTable.COUNTRY;
                    newRCMBo.Address = RcmTable.ADDRESS;


                    RcmBoList.Add(newRCMBo);
                }
            }
            catch (Exception ex)
            {

            }

            return RcmBoList;
        }


        public List<RCMBo> ViewRcmByRegion(string region)
        {
            List<PD3RCM> RcmTableList = new List<PD3RCM>();
            List<RCMBo> RcmBoList = new List<RCMBo>();

            try
            {
                using (var dbContext = new Model2())
                {
                    RcmTableList = dbContext.PD3RCM.Where(r => r.REGION == region).ToList<PD3RCM>();
                }

                foreach (PD3RCM RcmTable in RcmTableList)
                {
                    RCMBo newRCMBo = new RCMBo();
                    newRCMBo.RcmId = RcmTable.RCMID;
                    newRCMBo.Name = RcmTable.RCM_NAME;
                    newRCMBo.DateOfJoining = RcmTable.DATEOFJOINING;
                    newRCMBo.Email = RcmTable.EMAILID;
                    newRCMBo.Region = RcmTable.REGION;
                    newRCMBo.Country = RcmTable.COUNTRY;
                    newRCMBo.Address = RcmTable.ADDRESS;


                    RcmBoList.Add(newRCMBo);
                }
            }
            catch (Exception ex)
            {

            }

            return RcmBoList;
        }

        public RCMBo GetRcmDetails(int RcmId)
        {
            PD3RCM RcmTable = new PD3RCM();

            RCMBo newRCMBo = new RCMBo();

            try
            {
                using (var dbContext = new Model2())
                {
                    RcmTable = dbContext.PD3RCM.FirstOrDefault<PD3RCM>(e => e.RCMID == RcmId);
                }

                if (RcmTable != null)
                {
                    newRCMBo.RcmId = RcmTable.RCMID;
                    newRCMBo.Name = RcmTable.RCM_NAME;
                    newRCMBo.DateOfJoining = RcmTable.DATEOFJOINING;
                    newRCMBo.Email = RcmTable.EMAILID;
                    newRCMBo.Region = RcmTable.REGION;
                    newRCMBo.Country = RcmTable.COUNTRY;
                    newRCMBo.Address = RcmTable.ADDRESS;
                }
            }
            catch (Exception ex)
            {

            }
            return newRCMBo;
        }

        public void UpdateRcm(RCMBo NewRcmBo)
        {
            PD3RCM NewRcmTable = new PD3RCM();

            try
            {
                using (var dbContext = new Model2())
                {
                    NewRcmTable = dbContext.PD3RCM.First(e => e.RCMID == NewRcmBo.RcmId);


                    NewRcmTable.RCM_NAME = NewRcmBo.Name;
                    NewRcmTable.DATEOFJOINING = NewRcmBo.DateOfJoining;
                    NewRcmTable.EMAILID = NewRcmBo.Email;
                    NewRcmTable.REGION = NewRcmBo.Region;
                    NewRcmTable.COUNTRY = NewRcmBo.Country;
                    NewRcmTable.ADDRESS = NewRcmBo.Address;
                    dbContext.SaveChanges();
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        public void DeleteRcm(int RcmId)
        {
            try
            {
                PD3RCM NewRcmTable = new PD3RCM();
                using (var dbContext = new Model2())
                {
                    NewRcmTable = dbContext.PD3RCM.First(e => e.RCMID == RcmId);

                    dbContext.Entry(NewRcmTable).State = System.Data.Entity.EntityState.Deleted;

                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }



    }
}
