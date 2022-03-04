namespace StirrerApp
{
    public class BaseStirrer
    {
        public string Name { get; protected set; }
        virtual public int Rpm { get; set; }
        public StirrerMode Mode { get; set; }
    }
}