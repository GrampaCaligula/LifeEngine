namespace LifeEngine
{
    public interface ILifeObject
    {
        LifeObject.LifeFormGender Gender { get; set; }
        string Id { get; }
        bool IsAlive { get; set; }
        int Age { get; set; }
        int MaxAge { get; set; }

        void TerminateLifeForm();
    }
}