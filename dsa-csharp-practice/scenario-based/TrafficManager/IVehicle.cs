namespace CG_Practice.oopsscenario.TrafficManager
{
    public interface IVehicle
    {
        int GetVehicleId();
        string GetVehicleType();
        string GetLicensePlate();
        void DisplayInfo();
    }
}