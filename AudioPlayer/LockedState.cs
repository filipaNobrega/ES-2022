namespace AudioPlayer
{
    public class LockedState : State
    {
        public LockedState(AudioPlayer player) : base(player)
        {
        }

        public override string ClickLock()
        {
            if (Player.IsPlaying)
            {
                Player.ChangeState(new ReadyState(Player));
                return "Stop playing";
            }
            else
            {
                return "Locked...";
            }
        }

        public override string ClickPlay()
        {
            Player.ChangeState(new ReadyState(Player));
            return "Ready";
        }

        public override string ClickNext()
        {
            return "Locked...";
        }

        public override string ClickPrevious()
        {
            return "Locked...";
        }
    }
}