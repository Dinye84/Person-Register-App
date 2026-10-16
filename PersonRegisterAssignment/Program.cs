namespace PersonRegisterAssignment
{
    internal static class Program
    {
        internal static void Main(string[] argument)
        {
            // To switch between hardcoded and imported data, add the value "1" or "2" below.
            RegisterFunctions.SelectDataSource(1/*switch here*/);

            RegisterFunctions.SelectEntryPoint(argument);
            
            PrintFunctions.PrintBanner(); 
            
            Menu.GetMenu(RegisterFunctions.GetDataSource(RegisterFunctions.SelectedDataSource));
        }
    }
}

