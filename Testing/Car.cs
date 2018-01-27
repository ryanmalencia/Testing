namespace Testing
{
    class Car : Vehicle
    {
        protected string Name;
        public Car() : base()
        {
            Wheels = 4;
        }

        public Car(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
