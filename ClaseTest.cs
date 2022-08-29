namespace csproyects
{
    /// <summary>
    /// This is Animal interface.
    /// </summary>
    public interface IAnimal
    {
        void Breath();
        void Eat();
    }

    /// <inheritdoc></inheritdoc>
    public class Gato : IAnimal
    {
        public void Breath()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }
}