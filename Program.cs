#region 车牌校正
using HalconWithCsharp.VehicleCard;
using HalconWithCsharp.HKCamera;
using HalconWithCsharp.AdhesiveBead;
#endregion

namespace HalconWithCsharp_CarCard
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Adhesivebead());
        }
    }
}