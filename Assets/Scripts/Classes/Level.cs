using System;

namespace Classes
{
    public class Level
    {
        private int number;
        private int world;
        private string unityTag;
        private bool locked;
        private bool completed;
        private TimeSpan completionTime;
        private int starsEarned;

        public Level(int number, int world, string unityTag, bool locked, bool completed, TimeSpan completionTime, int starsEarned)
        {
            this.number = number;
            this.world = world;
            this.unityTag = unityTag;
            this.locked = locked;
            this.completed = completed;
            this.completionTime = completionTime;
            this.starsEarned = starsEarned;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public int World
        {
            get => world;
            set => world = value;
        }

        public string UnityTag
        {
            get => unityTag;
            set => unityTag = value;
        }

        public bool Locked
        {
            get => locked;
            set => locked = value;
        }

        public bool Completed
        {
            get => completed;
            set => completed = value;
        }

        public TimeSpan CompletionTime
        {
            get => completionTime;
            set => completionTime = value;
        }

        public int StarsEarned
        {
            get => starsEarned;
            set => starsEarned = value;
        }
    }
}