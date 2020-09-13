using TMPro;

namespace Core.UI
{
    public class Score : EntityBehaviour
    {
        public TextMeshProUGUI Text;

        protected override void OnStart()
        {
            base.OnStart();
            Entity
                .AddScore(0)
                .AddText(Text);
        }
    }
}