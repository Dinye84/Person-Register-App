namespace PersonRegisterAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFunctions.PrintBanner();
            // To switch between hardcoded and imported data, add the value "1" or "2" below.
            Menu.GetMenu(RegisterFunctions.SelectDataSource(-1/*Data source*/)); 

        }
    }
}

