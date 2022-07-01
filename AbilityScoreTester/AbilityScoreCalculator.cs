using System;
using System.Collections.Generic;
using System.Text;

namespace AbilityScoreTester
{
    class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            // Divide roll by the DivideBy field
            double divided = RollResult / DivideBy;

            // Add AddAmount to the result of above division
            int added = AddAmount + (int) divided;

            // If result is too small, use Minimum

            if (added < Minimum)
                Score = Minimum;
            else
                Score = added;
        }

    }
}
