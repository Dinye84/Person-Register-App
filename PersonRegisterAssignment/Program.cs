namespace PersonRegisterAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = Person.GetPeople();
            RegisterFunctions.PrintInfo(person[1].Name);
        }
    }
}

