using TMPro;
using UnityEngine.UI;

namespace Core.UI
{
    public class Score : EntityBehaviour
    {
        public TextMeshProUGUI text;

        protected override void OnStart()
        {
            base.OnStart();
            Entity.AddScore(0);
        }
    }
}