using AgeOfVillagers.Model_Class_Folder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers.JSON_Handling_Classes_Folder
{
    class JsonConversion
    {
        String jsonData;
        public void serialize(StateModel currentState,string fileName)
        {
            if (fileName != "")
            {
                var dataString = JsonConvert.SerializeObject(currentState, Formatting.Indented);
                System.IO.File.WriteAllText(fileName, dataString);
                jsonData = dataString;
            }
            
        }

        public StateModel deserialize(string jsonData)
        {
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };



            StateModel  previouslySavedState = JsonConvert.DeserializeObject<StateModel>(jsonData, settings);
            return previouslySavedState;
        }
    }
}
