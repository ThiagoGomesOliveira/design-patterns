namespace Isp.Vehicles
{
    interface IVehicle
    {
        void StartVehicle();
        void ConfigureMotorcycle(string color, int year, double engine);
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
    }
}
