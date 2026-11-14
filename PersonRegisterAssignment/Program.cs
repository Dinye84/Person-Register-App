using PersonRegisterAssignment.Resources.Texts;
using System.Resources;
//using static PersonRegisterAssignment.RegisterFunctions;

namespace PersonRegisterAssignment
{
    internal static class Program
    {
        internal static void Main(string[] argument)
        {
            PrintFunctions.PrintBanner();
            RegisterFunctions.SelectDataSourcePath(argument);
            Menu.GetMenu(RegisterFunctions.GetDataSource(RegisterFunctions.SelectedDataSource));
        }
    }
}

