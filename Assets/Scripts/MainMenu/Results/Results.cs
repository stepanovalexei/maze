using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace MainMenu.Results
{
    [Serializable]
    public class Results
    {
        public List<Result> List;

        public static Results Get()
        {
            Results results = null;

            if (File.Exists(FilePath()))
            {
                try
                {
                    var resultsAsText = File.ReadAllText(FilePath());
                    results = JsonConvert.DeserializeObject<Results>(resultsAsText);
                }
                catch
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