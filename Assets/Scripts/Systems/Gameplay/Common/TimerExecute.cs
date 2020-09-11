using Entitas;

namespace Systems.Gameplay.Common
{
    public abstract class TimerExecute : IExecuteSystem
    {
        private float timeToNextExecute;
        private readonly float executeIntervalInSeconds;

        protected TimerExecute(float executeIntervalInSeconds) =>
            this.executeIntervalInSeconds = executeIntervalInSeconds;

        protected abstract void Execute();

        void IExecuteSystem.Execute()
        {
            timeToNextExecute -= Contexts.sharedInstance.game.Time.DeltaTime;
            if (timeToNextExecute > 0)
                return;

            timeToNextExecute = executeIntervalInSeconds;

            this.Execute();
        }
    }
}