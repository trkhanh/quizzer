using System;

namespace quizzer.Models
{
    public class Question
    {
        private string _text;
        /// <summary>
        /// The question text.
        /// </summary>
        public string Text
        {
            get => _text;
            set => SetProperty
        }
    }
}
