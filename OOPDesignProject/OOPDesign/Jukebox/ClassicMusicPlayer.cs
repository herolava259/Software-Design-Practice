using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.Jukebox;

public class ClassicMusicPlayer : IMusicPlayer
{
    private readonly ClassicJukeBox jukebox;

    public ClassicMusicPlayer(ClassicJukeBox jukebox)
    {
        this.jukebox = jukebox;
    }
    public bool IsPlaying => throw new NotImplementedException();

    public Record Record => throw new NotImplementedException();

    public bool DecreaseVolume(float volume)
    {
        throw new NotImplementedException();
    }

    public bool IncreaseVolume(float volume)
    {
        throw new NotImplementedException();
    }

    public void Pause()
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        throw new NotImplementedException();
    }

    public bool PlayBack()
    {
        throw new NotImplementedException();
    }

    public bool Quit()
    {
        throw new NotImplementedException();
    }

    public bool Resume()
    {
        throw new NotImplementedException();
    }

    public string RetrieveInformation()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
