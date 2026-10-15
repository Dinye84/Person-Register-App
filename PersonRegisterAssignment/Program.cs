namespace PersonRegisterAssignment
{
    internal static class Program
    {
        internal static void Main(string[] argument)

        {
            //string[] command = { "list" };
            //string[] command = { "list", "--top5" };
            //string[] command = { "list", "--sort" };
            //string[] command = { "list", "--sort", "--top5" };
            //string[] command = { "list", "--search", "a" };

            RegisterFunctions.SelectEntryPoint(argument);
            //FORTSÄTT HÄR, FÖRSÖK DEBUGGA GENOM ATT SKICKA IN ARGUMENT VIA PROPERTIES
            //KOLLA SÅ ATT ALLT FUNKAR SOM DET SKA MED COMMAND

            PrintFunctions.PrintBanner();
            // To switch between hardcoded and imported data, add the value "1" or "2" below.
            Menu.GetMenu(RegisterFunctions.SelectDataSource(1/*Data source*/));
            
        }
    }
}

