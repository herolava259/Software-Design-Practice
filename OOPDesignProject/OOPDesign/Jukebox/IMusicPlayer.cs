
namespace OOPDesign.Jukebox;

public interface IMusicPlayer
{
    public void Play(); 
    public void Stop();

    public void Pause();

    public bool Resume();

    public bool PlayBack();

    public bool IncreaseVolume(float volume);

    public bool DecreaseVolume(float volume);

    public bool Quit();

    public string RetrieveInformation();
    public bool IsPlaying { get; }

    public Record Record { get; }
}
