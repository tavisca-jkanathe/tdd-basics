using System;

namespace BowlingBall
{
    public class Game
    {
        int[] rolls = new int[21];
        int currentRoll = 0;
        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int GetScore()
        {
            int score = 0;
            int frameIndex = 0;
			for (int frames = 0; frames < 10; frames++) {

				//cases for strike and spare
				if (rolls[frameIndex] == 10) 
                {
                    score = score + 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex += 1;
                }
                else if(rolls[frameIndex] + rolls[frameIndex + 1] == 10)
                {
                    score = sccore + 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score = score + rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
			return score;
        }

    }
}

