using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;

namespace MainMenu.Results
{
    [Serializable]
    public class Results
    {
        private const string Format = "dd.MM.yyyy";
        private static List<string> errors = new List<string>();
        
        public List<Result> List;

        public static Results Get()
        {
            Results results = null;

            if (File.Exists(FilePath()))
            {
                try
                {
                    var resultsAsText = File.ReadAllText(FilePath());
                    var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = Format };
                    results = JsonConvert.DeserializeObject<Results>(resultsAsText, new JsonSerializerSettings
                    {
                        Error = delegate(object sender, ErrorEventArgs args)
                        {
                            errors.Add(args.ErrorContext.Error.Message);
                            args.ErrorContext.Handled = true;
                        },
                        Converters = { new IsoDateTimeConverter() }
                    });
                }
                catch (Exception ex)
                {
                    Debug.LogError("Could not deserialize results.");
                }
            }

            return results ?? Empty();
        }

        public static void Add(Result result)
        {
            var results = Get();

            results.List.Add(result);

            try
            {
                File.WriteAllText(FilePath(), JsonConvert.SerializeObject(results));
            }
            catch
            {
                Debug.LogError("Could not save results.");
            }
        }

        private static Results Empty() => new Results {List = new List<Result>()};

        private static string FilePath() => Path.Combine(Application.streamingAssetsPath, "Results.json");
    }
}