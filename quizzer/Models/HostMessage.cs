using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace quizzer.Models
{
    /// <summary>
    /// An enumeration representing the available types of message that the host can send to players.
    /// </summary>
    public enum HostMessageType
    {
        Scoreboard = 0,
        Question,
        GameStarted,
        GameOver
    };

    [DataContract]
    public class HostMessage
    {
        /// <summary>
        /// The time that the host message was sent.
        /// </summary>
        [DataMember]
        public DateTime TimeSent { get; set; }

        /// <summary>
        /// The type of message.
        /// </summary>
        [DataMember]
        public HostMessageType Type { get; set; }

        /// <summary>
        /// The question to be answered.
        /// </summary>
        [DataMember]
        public Question Question { get; set; }

        /// <summary>
        /// The score board displaying results.
        /// </summary>
        [DataMember]
        public ObservableCollection<Scorecard> PlayerScores { get; set; }
    }


}
