namespace CG_Practice.oopsscenario.TrafficManager
{
    public class Vehicle : IVehicle
    {
        private int vehicleId;
        private string vehicleType;
        private string licensePlate;

        public Vehicle(int id, string type, string plate)
        {
            vehicleId = id;
            vehicleType = type;
            licensePlate = plate;
        }

        public int GetVehicleId()
        {
            return vehicleId;
        }

        public string GetVehicleType()
        {
            return vehicleType;
        }

        public string GetLicensePlate()
        {
            return licensePlate;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {vehicleId} | Type: {vehicleType} | Plate: {licensePlate}");
        }
    }
}