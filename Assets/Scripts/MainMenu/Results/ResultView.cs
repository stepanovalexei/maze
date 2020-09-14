using TMPro;
using UnityEngine;

namespace MainMenu.Results
{
    public class ResultView : MonoBehaviour
    {
        public TextMeshProUGUI Name;
        public TextMeshProUGUI Score;
        public TextMeshProUGUI Started;
        public TextMeshProUGUI Spent;
        public TextMeshProUGUI EndReason;

        public void Initialize(string name, string score, string date, string spent, string reason)
        {
            Name.text = name;
            Score.text = score;
            Started.text = date;
            Spent.text = spent;
            EndReason.text = reason;
        }
    }
}