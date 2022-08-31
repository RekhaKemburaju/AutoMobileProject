/*  Assuming I am the looking at the vechical's mileage meter and recording
   in ascending order because the mileage only increases after each drive.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoMobileProject
{
    public class MainAutoMobile
    {
        public static void Main(String[] args)
        {
            

            List<Vehicle> VehicleList = new List<Vehicle>();

            //New Vehicle0
            Vehicle newVehicleObj_0 = new Vehicle("car", 40000);
            newVehicleObj_0.updateMileage(14000);
            newVehicleObj_0.updateMileage(15000);
            newVehicleObj_0.updateMileage(20000);
            newVehicleObj_0.updateMileage(35000);
            newVehicleObj_0.updateMileage(60000);
            newVehicleObj_0.updateMileage(120000);

            //New Vehicle1
            Vehicle newVehicleObj_1 = new Vehicle("bus",50000);
            newVehicleObj_1.updateMileage(14000);
            newVehicleObj_1.updateMileage(15000);
            newVehicleObj_1.updateMileage(20000);
            newVehicleObj_1.updateMileage(35000);
            newVehicleObj_1.updateMileage(60000);
            newVehicleObj_1.updateMileage(150000);

            //New Vehicle2
            Vehicle newVehicleObj_2 = new Vehicle("bike", 30000);
            newVehicleObj_2.updateMileage(14000);
            newVehicleObj_2.updateMileage(15000);
            newVehicleObj_2.updateMileage(27000);
            newVehicleObj_2.updateMileage(35000);
            newVehicleObj_2.updateMileage(60000);
            newVehicleObj_2.updateMileage(150000);

            //Secondhand Vehicle3
            Vehicle oldVehicleObj_3 = new Vehicle("truck", 600000, 6000);
            oldVehicleObj_3.updateMileage(14000);
            oldVehicleObj_3.updateMileage(15000);
            oldVehicleObj_3.updateMileage(10000);
            oldVehicleObj_3.updateMileage(35000);
            oldVehicleObj_3.updateMileage(60000);
            oldVehicleObj_3.updateMileage(60000);
            oldVehicleObj_3.updateMileage(150000);


            VehicleList.Add(newVehicleObj_0);
            VehicleList.Add(newVehicleObj_1);
            VehicleList.Add(newVehicleObj_2);
            VehicleList.Add(oldVehicleObj_3);


            for (int i = 0; i < VehicleList.Count; i++)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("VechicleObj" + i + " details ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Vechicle Type: " + VehicleList[i].getVechicleType());
                Console.WriteLine("No of tyres: " + VehicleList[i].getNoOfTyres());
                Console.WriteLine("Valuation: " + VehicleList[i].getValuation());
                Console.WriteLine("Mileage: " + VehicleList[i].getMileage());
                for (int j = 0; j < VehicleList[i].serviceHistory.Count; j++)
                {
                    Console.WriteLine("Service History: " + VehicleList[i].serviceHistory[j]);
                }


            }  




     
        }
    }
}
