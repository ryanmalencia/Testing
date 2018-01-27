namespace Testing
{
    interface IDriveable
    {
        bool AddDriver(Driver driver);
        int Accelerate(int percent);
        int Brake(int percent);
        int Turn(bool dir, int percent);
        string GetName();
    }
}
