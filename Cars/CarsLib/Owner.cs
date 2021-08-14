namespace CarsLib
{
    public class Owner
    {
        
        public string Name { get; set; }
        public long LicenceNo { get; set; }

       public Owner(string name, long pLicenceNo)
        {
            SetLicenceNo(pLicenceNo);
            this.Name = name;
        }
        public void SetLicenceNo(long pLicenceNo){
            /*
            ensures that LicenceNo is exactly 10 digits.  If not, set licenceNo to 0. 
            */
            string LicAsString = pLicenceNo.ToString();
            if (LicAsString.Length != 10){
                pLicenceNo = 0;
            }
            LicenceNo = pLicenceNo;
        } 
    }
}