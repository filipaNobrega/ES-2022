namespace AudioPlayer
{
    public abstract class State
    {
        protected AudioPlayer Player { get; }

        protected State(AudioPlayer player)
        {
            Player = player;
        }

        public abstract string ClickLock();
        public abstract string ClickPlay();
        public abstract string ClickNext();
        public abstract string ClickPrevious();
    }
}