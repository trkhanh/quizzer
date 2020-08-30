using System;

namespace quizzer.Models
{
    public class PlayerMessage
    {
        /// <summary>
        /// The command requested by the player.
        /// </summary>
        public PlayerMessageType Type { get; set; }

        /// <summary>
        /// The name of the player that sent the command.
        /// </summary>
        public string PlayerName { get; set; }

        /// <summary>
        /// The question that was answered.
        /// </summary>
        public Question Question { get; set; }

        /// <summary>
        /// The index of the Question.Options list that the player chose.
        /// </summary>
        public bool IsCorrect { get; set; }

        /// <summary>
        /// The amount of time that was taken to answer the question.
        /// </summary>
        public TimeSpan AnswerTime { get; set; }
    }

    /// <summary>
    /// An enumeration representing the available commands that players can send to the game host.
    /// </summary>
    public enum PlayerMessageType
    {
        Join = 0,
        Leave,
        Answer
    };
}
