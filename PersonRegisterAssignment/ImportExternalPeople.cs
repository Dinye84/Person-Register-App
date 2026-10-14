using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Text.Json;

namespace PersonRegisterAssignment
{
    internal class ImportExternalPeople : IPeopleDataSources
    {
        private readonly string _filePath = @"C:\Users\Andreas\CodeProjects\PersonRegisterAssignment\PersonRegisterAssignment\externalPeopleData.JSON";

        public List<Person> GetPeople()
        {
             if(!File.Exists(_filePath))
            {
                return [];
            }
            var json = File.ReadAllText(_filePath);
            var people = JsonSerializer.Deserialize<List<Person>>(json) ?? [];
            return people;
        }
    }
}