using TraficLight.Models;

namespace TraficLight.ModelsLogic
{
    internal class LightImage : LightImageModel
    {
        public override string GetLightImage(TraficLightModel.TraficLightState tls)
        {
            return lightImages[(int)tls];
        }
    }
}
