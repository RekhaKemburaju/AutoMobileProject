using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AutoMobileProject
{
    public class Vehicle
    {
        private String VechicleType;
        private int NoOfTyres;
        private double valuation;
        private double mileage;
        public List<string> serviceHistory = new List<string>();

        static readonly double VALUATION_REDUCTION = 2000;
        static readonly double MILEAGE_REDUCTION = 15000;
        static readonly double MINOR_MILEAGE = 12000;
        static readonly double MAJOR_MILEAGE = 24000;
        static readonly double TYER_MILEAGE = 35000;

        //Create new Vechicle
        public Vehicle(String VechicleType, double valuation)
        {
            this.VechicleType = VechicleType.Trim();
            this.NoOfTyres = checkVechicleType(this.VechicleType);
            this.valuation = valuation;
            mileage = 0;
        }
        //Secondhand Vehicle
        public Vehicle(String VechicleType, double valuation, double mileage)
        {

            this.VechicleType = VechicleType.Trim();
            this.NoOfTyres = checkVechicleType(this.VechicleType);
            this.valuation = valuation;
            this.mileage = mileage;

        }
        public int checkVechicleType(String VechicleType)
        {

            int CNoOfTyres = 0;
            VechicleType = VechicleType.ToLower();
            if (VechicleType == "car" || VechicleType == "van" || VechicleType == "bus")
                return CNoOfTyres = 4;
            else if (VechicleType == "motorbike" || VechicleType == "bike" || VechicleType == "scooter" || VechicleType == "bike" || VechicleType == "cycle")
                return CNoOfTyres = 2;
            else if (VechicleType == "truck")
                CNoOfTyres = 6;

            return CNoOfTyres;

        }
        public void setVechicleType(String VechicleType)
        {
            this.VechicleType = VechicleType;
        }
        public String getVechicleType()
        {
            return VechicleType;
        }
        public void setNoOfTyres(int NoOfTyres)
        {
            this.NoOfTyres = NoOfTyres;
        }
        public int getNoOfTyres()
        {
            return NoOfTyres;
        }
        public void setValuation(double valuation)
        {
            this.valuation = valuation;
        }
        public double getValuation()
        {
            return valuation;
        }
        public void setMileage(double mileage)
        {
            this.mileage = mileage;
        }
        public double getMileage()
        {
            return mileage;
        }
        public void updateMileage(double mileage)
        {

            double pastMileage = this.mileage;
            double persentMileage = mileage;
            double diffrence = persentMileage - pastMileage;
            // Console.WriteLine("*****************************************");
            // Console.WriteLine("past Mileage: " + pastMileage);
            // Console.WriteLine("persent Mileage: " + persentMileage);
            // Console.WriteLine("Diffrence Mileage: " + diffrence);

            if ((diffrence < MILEAGE_REDUCTION) && (diffrence >= MINOR_MILEAGE))
            {
                //Creates a service history entry every 12000 kms as minor service completed			
                serviceHistory.Add("Had a minor service completed");

            }
            else if (diffrence >= MILEAGE_REDUCTION)
            {


                //Change the valuation to reduce by 2000 every 15000 kms
                int j = (int)(diffrence / MILEAGE_REDUCTION);
                for (int i = 0; i < j; i++)
                {
                    this.valuation = this.valuation - VALUATION_REDUCTION;
                }

                if ((diffrence < TYER_MILEAGE) && (diffrence >= MAJOR_MILEAGE))
                {
                    //Creates a service history every 24000 kms as major service completed				
                    serviceHistory.Add("Had a major service completed");


                }
                else if (diffrence >= TYER_MILEAGE)
                {
                    //Creates  service history of tyres changed every 35000 kms				
                    int a = (int)(diffrence / TYER_MILEAGE);
                    for (int i = 0; i < a; i++)
                    {
                        serviceHistory.Add("Tyres are changed");
                    }

                    double leftover = diffrence - (a * TYER_MILEAGE);
                    addHistory(leftover);

                }
            }

            this.mileage = this.mileage + diffrence;
            //
            //Console.WriteLine("Updated Mileage : " + this.mileage);

        }

        public void addHistory(double leftOver)
        {
           // Console.WriteLine("LeftOver:" + leftOver);
            if ((leftOver < MAJOR_MILEAGE) && (leftOver >= MINOR_MILEAGE))
            {
                //Creates a service history entry every 12000 kms as minor service completed			
                serviceHistory.Add("Had a minor service completed");

            } 
            if ((leftOver < TYER_MILEAGE) && (leftOver >= MAJOR_MILEAGE))
            {
                    //Creates a service history every 24000 kms as major service completed				
                    serviceHistory.Add("Had a major service completed");


             }
             if (leftOver >= TYER_MILEAGE)
             {
                    //Creates  service history of tyres changed every 35000 kms				
                    int a = (int)(leftOver / TYER_MILEAGE);
                    for (int i = 0; i < a; i++)
                    {
                        serviceHistory.Add("Tyres are changed");
                    }
                    double leftover = leftOver - (a * TYER_MILEAGE);
                    addHistory(leftover);

                }

            



        }
    }
}
