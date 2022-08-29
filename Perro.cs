namespace csproyects
{
    /// <inheritdoc/>
    public class Perro : IAnimal
    {

        public void Breath()
        {
            System.Console.WriteLine("El perro esta respirando...");
        }

        public void Eat()
        {
            System.Console.WriteLine("El perro esta comeindo...");
        }
    }
}