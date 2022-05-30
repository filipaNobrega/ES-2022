namespace AudioPlayer
{
    public class AudioPlayer
    {
        private readonly List<string> _playlist = new();
        private int _currentTrack = 0;

        private State _state;

        private bool _isPlaying;
        public bool IsPlaying { get => _isPlaying; set => _isPlaying = value; }

        public AudioPlayer()
        {
            _state = new ReadyState(this);
            for (int i = 0; i <= 12; i++)
            {
                _playlist.Add($"Track {i}");
            }
        }

        public string ClickLock() => _state.ClickLock();
        public string ClickPlay() => _state.ClickPlay();
        public string ClickNext() => _state.ClickNext();
        public string ClickPrevious() => _state.ClickPrevious();

        public void ChangeState(State state)
        {
            _state = state;
        }

        public string Play()
        {
            return "Playing " + _playlist[_currentTrack];
        }

        public string NextTrack()
        {
            _currentTrack++;
            if (_currentTrack > _playlist.Count - 1)
            {
                _currentTrack = 0;
            }
            return "Playing " + _playlist[_currentTrack];
        }

        public string PreviousTrack()
        {
            _currentTrack--;
            if (_currentTrack < 0)
            {
                _currentTrack = _playlist.Count - 1;
            }
            return "Playing " + _playlist[_currentTrack];
        }

        public void ResetCurrentTrackAfterStop()
        {
            _currentTrack = 0;
        }
    }
}