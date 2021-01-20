using Raylib_cs;
using System;
using System.Collections.Generic;
using UntitledCore;
using System.IO;
using Newtonsoft.Json;

namespace UntitledGameEngine
{
    class Program
    {

        static void Main(string[] args)
        {
            JsonSerializer.CreateDefault(GetJsonSettings()); 
            EngineConfig config = new EngineConfig();
            
            if (File.Exists("EngineSettings.json"))
            {
                string EngineSettings = File.ReadAllText("EngineSettings.json");
                config = JsonConvert.DeserializeObject<EngineConfig>(EngineSettings);
            }
            else
            {
                File.Create("EngineSettings.json").Close();
                File.WriteAllText("EngineSettings.json", JsonConvert.SerializeObject(config));
            }



            Engine engine = new Engine(config);


            engine.Run();

        }

        static JsonSerializerSettings GetJsonSettings()
        {
            return new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                DefaultValueHandling = DefaultValueHandling.Ignore,
            };
        }
    }
}
