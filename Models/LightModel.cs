namespace TraficLight.Models
{
    internal abstract class LightModel(Color color,bool isOn)
    {
        protected Color color = color;
        public bool IsOn { get; set; } = isOn;
        public abstract Color Color { get;}
    }
}
