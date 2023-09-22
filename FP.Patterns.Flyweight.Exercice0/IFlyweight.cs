namespace FP.Patterns.Flyweight
{
    internal interface IFlyweight
    {
        void AddName(string name);
        void CalculatePrice();
        void Show();
        string GetName();
    }
}
