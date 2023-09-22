namespace FP.Patterns.Flyweight
{
    internal class FlyweightFactory
    {
        private List<IFlyweight> _flyweights = new List<IFlyweight>();
        private int _count = 0;

        public int Count { get => _count; set => _count = value; }

        public int Add(string name)
        {
            //Check if the flyweight already exists
            bool exists = false;
            foreach(IFlyweight flyweight in _flyweights)
            {
                if(flyweight.GetName() == name)
                {
                    exists = true;
                }
            }

            if (exists)
            {
                Console.WriteLine("Flyweight {0} already exists", name);
                return -1;
            }
            else
            {
                Recipe recipe = new Recipe();
                recipe.AddName(name);
                _flyweights.Add(recipe);
                _count = _flyweights.Count;
                return _count - 1;
            }
        }

        public IFlyweight this[int index]
        {
            get
            {
                return _flyweights[index];
            }
        }
    }
}
