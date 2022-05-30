namespace AudioPlayer
{
    public class ReadyState : State
    {
        public ReadyState(AudioPlayer player) : base(player)
        {
        }

        public override string ClickLock()
        {
            Player.IsPlaying = false;
            Player.ChangeState(new LockedState(Player));
            return "Locked...";
        }

        public override string ClickPlay()
        {
            string action = Player.Play();
            Player.IsPlaying = true;
            Player.ChangeState(new PlayingState(Player));
            return action;
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