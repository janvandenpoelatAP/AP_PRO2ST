namespace BowlingGameScore
{
    public class BowlingGame
    {
        private int[] pins = new int[21];  // het aantal omgeworpen kegels per worp (maximaal 21 worpen laatste frame een spare + 1 of strike + 2;
        private int currentRoll = 0;       // teller van het aantal worpen die de gebruiker heeft gedaan

        public int Score
        {
            get
            {
                int score = 0;
                int rollIndex = 0;
                for (int frame = 0; frame < 10; frame++) // loop over het aantal worpen
                {
                    if (IsStrike(rollIndex)) // Strike
                    {
                        score += GetStrikeScore(rollIndex);
                        rollIndex++;
                    }
                    else if (IsSpare(rollIndex)) // Spare
                    {
                        score += GetSpareScore(rollIndex);
                        rollIndex += 2;
                    }
                    else
                    {
                        score += GetStandardScore(rollIndex);
                        rollIndex += 2;
                    }
                }

                return score;
            }
        }

        public void Roll(int pinsThisRoll)
        {
            pins[currentRoll++] = pinsThisRoll;
        }
        private bool IsStrike(int rollIndex)
        {
            return pins[rollIndex] == 10;
        }
        private bool IsSpare(int rollIndex)
        {
            return pins[rollIndex] + pins[rollIndex + 1] == 10;
        }
        private int GetStrikeScore(int rollIndex)
        {
            return pins[rollIndex] + pins[rollIndex + 1] + pins[rollIndex + 2];
        }
        private int GetSpareScore(int rollIndex)
        {
            return pins[rollIndex] + pins[rollIndex + 1] + pins[rollIndex + 2];
        }
        private int GetStandardScore(int rollIndex)
        {
            return pins[rollIndex] + pins[rollIndex + 1];
        }
    }
}
