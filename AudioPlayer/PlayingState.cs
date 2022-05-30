namespace AudioPlayer
{
    public class PlayingState : State
    {
        public PlayingState(AudioPlayer player) : base(player)
        {
        }

        public override string ClickLock()
        {
            Player.IsPlaying = false;
            Player.ChangeState(new LockedState(Player));
            Player.ResetCurrentTrackAfterStop();
            return "Stop playing";
        }

        public override string ClickNext()
        {
            return Player.NextTrack();
        }

        public override string ClickPlay()
        {
            Player.ChangeState(new ReadyState(Player));            
            return "Paused...";
        }

        public override string ClickPrevious()
        {
            return Player.PreviousTrack();
        }
    }
}