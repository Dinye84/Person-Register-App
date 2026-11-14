using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Text.Json;

namespace PersonRegisterAssignment
{
    internal class ImportExternalPeople : IPeopleDataSources
    {
        private readonly string _filePath = @".\externalPeopleData.JSON";
        public List<Person> GetPeople()
        {
            if(!File.Exists(_filePath)) //JSON FILEN RETURNERAS EJ, KOLLA VARFÖR
            {
                return [];
            }
            

            var json = File.ReadAllText(_filePath);
            var people = JsonSerializer.Deserialize<List<Person>>(json) ?? [];
            return people;
        }
    }
}