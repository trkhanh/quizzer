
using Windows.System.RemoteSystems;

namespace quizzer.Models
{
    public class Game
    {
        public string Name { get; set; }
        public RemoteSystemSessionInfo Info { get; set; }
    }
}
