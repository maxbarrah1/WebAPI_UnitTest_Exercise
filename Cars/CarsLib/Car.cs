using System;

namespace CarsLib
{
    public class Car
    {
        public string Rego { get; set; }
        public int Speed { get; set; }

        public Car(string pRego, int pSpeed)
        {
            SetRego(pRego);
            Speed = 0;
            AddSpeed(pSpeed);
        }

        public void SetRego(string pRego){
            /*
            void  SetRego(string rego) - ensures that Rego is only six character long.  
            If longer, truncate to six.  If shorter, fill up to six with 'A'.  
            This method should be used in the constructors
            */
            pRego = pRego.ToUpper();

            if (pRego.Length > 6){
                pRego = pRego.Substring(0,6);
            }
            else if (pRego.Length < 6){
                for (int i = pRego.Length; i<6; i++){
                    pRego += "A";
                }
            }
            Rego = pRego;
        } 

        public void AddSpeed(int pSpeed){
            /*
            void AddSpeed(int speed) - ensures that Speed cannot be greater 
            that 130 and never less than -10.  If greater than 130, set to 130.  
            If less than -10, set to -10.
            */
            int newSpeed = Speed + pSpeed;
            if (newSpeed > 130){
                newSpeed = 130;
            }
            else if (newSpeed < -10){
                newSpeed = - 10;
            }

            Speed = newSpeed;
        }
    }
}
