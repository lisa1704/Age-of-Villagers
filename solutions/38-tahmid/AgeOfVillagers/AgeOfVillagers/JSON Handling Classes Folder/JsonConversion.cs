using AgeOfVillagers.Model_Class_Folder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers.JSON_Handling_Classes_Folder
{
    class JsonConversion
    {
        public string serialize(StateModel currentState)
        {
            string jsonData = JsonConvert.SerializeObject(currentState);
            return jsonData;
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
