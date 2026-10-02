namespace PersonRegisterAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> combinedPeopleDataList = Person.GetPeople();

            RegisterFunctions.PrintInfo(combinedPeopleDataList);
        }
    }
}

