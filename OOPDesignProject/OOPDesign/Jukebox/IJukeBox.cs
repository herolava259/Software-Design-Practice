

namespace OOPDesign.Jukebox;

public interface IJukeBox< in TRequest, out TSelector, out TPlayer>
    where TRequest: class, IPlayingRequest
    where TSelector : class,IMusicSelector
    where TPlayer : class, IMusicPlayer
{
    public TSelector MusicSelector { get; }

    public bool IsAvailable { get; }

    public TPlayer? AcceptPlayingRequest(TRequest? request);

    public bool QuitSession(Guid ticketId);


}
