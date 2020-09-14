using System;
using UnityEngine;
using static Constants;

namespace MainMenu.Results
{
    [Serializable]
    public class Result
    {
        public string PlayerName;
        public long Date;
        public int Score;
        public float TimeSpent;
        public int EndReason;

        public string DateConverted => DateTime.FromBinary(Date).ToString("HH:mm");
        public string ReasonConverted => ((GameEndReason) EndReason).ToString();
        public string TimeSpentFormatted
        {
            get
            {
                var timeSpan = TimeSpan.FromSeconds(TimeSpent);
                return $"{timeSpan.Minutes:D2}m:{timeSpan.Seconds:D2}s";
            }
        }

        private Result(long date, string playerName)
        {
            Date = date;
            PlayerName = playerName;
        }
        private Result()
        {
        }

        public static Result New() =>
            new Result(DateTime.Now.ToBinary(), PlayerPrefs.GetString(NameKey));

        public Result WithScore(int score)
        {
            Score = score;

            return this;
        }

        public Result WithTimeSpent(float timeSpent)
        {
            TimeSpent = timeSpent;


            return this;
        }

        public Result WithEndReason(GameEndReason reason)
        {
            EndReason = (int) reason;
            return this;
        }
    }
}