using System;
using System.Linq;
using UnityEngine;

namespace MainMenu.Results
{
    public class ResultsView : MonoBehaviour
    {
        public GameObject Result;

        private void Start()
        {
            Results.Get()
                .List
                .OrderByDescending(x => x.Date)
                .ToList()
                .ForEach(CreateAndInitialize());
        }

        private Action<Result> CreateAndInitialize() =>
            x => Instantiate(Result, transform)
                .GetComponent<ResultView>()
                .Initialize
                (
                    x.PlayerName,
                    x.Score.ToString(),
                    x.DateConverted,
                    x.TimeSpentFormatted,
                    x.ReasonConverted
                );
    }
}