using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mobileclaim.service
{
    public class Country
    {
        public List<MVCPD.region> GetRegionListFromDB()
        {
                
            using (MVCPD.Model4 dataContext = new MVCPD.Model4())
            {
                
                return dataContext.region.ToList();
            }
        }

        
        public List<string> GetCountryByRegionId(string Regionname)
        {
                
            using (MVCPD.Model4 dataContext = new MVCPD.Model4())
            {
                
                return dataContext.countries.Where(query => query.regionaname == Regionname).Select(q => q.countryname).ToList();
            }
        }

        public List<MVCPD.PD3RCM> GetIDListFromDB()
        {
            using (MVCPD.Model5 dataContext = new MVCPD.Model5())
            {

                return dataContext.PD3RCM.ToList();
            }
        }

        public List<MVCPD.PD3DEVICE2> GetDeviceListFromDB()
        {
            using (MVCPD.Model5 dataContext = new MVCPD.Model5())
            {

                return dataContext.PD3DEVICE2.ToList();
            }
        }
    }
}