namespace TraficLight.Models
{
    internal class LightChengedEventArgs(TraficLightModel.TraficLight light) : EventArgs
    {
        public TraficLightModel.TraficLight Light { get; } = light;
    }
}
