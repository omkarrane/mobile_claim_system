using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBO;
using JDAL;

namespace JBLL
{
    public class RCMbll
    {
        public int RCMdetails(RCMBo NewRcmBo)
        {
            RCMDal newrcmdal = new RCMDal();
            return newrcmdal.RCMdetails(NewRcmBo);
        }

        public List<RCMBo> ViewRcmById(int rcmID)
        {
            RCMDal newRcmDal = new RCMDal();

            List<RCMBo> RcmBoList = newRcmDal.ViewRcmById(rcmID);

            return RcmBoList;
        }

        public List<RCMBo> ViewRcmByRegion(string region)
        {
            RCMDal newRcmDal = new RCMDal();

            List<RCMBo> RcmBoList = newRcmDal.ViewRcmByRegion(region);

            return RcmBoList;
        }
        public RCMBo GetRcmDetails(int RcmId)
        {
            RCMDal newRcmDal = new RCMDal();
            return newRcmDal.GetRcmDetails(RcmId);
        }


        public void UpdateRcm(RCMBo NewRcmBo)
        {
            RCMDal newRcmDal = new RCMDal();
            newRcmDal.UpdateRcm(NewRcmBo);
        }
        public void DeleteRcm(int RcmId)
        {
            RCMDal newRcmDal = new RCMDal();

            newRcmDal.DeleteRcm(RcmId);
        }
    }
}
