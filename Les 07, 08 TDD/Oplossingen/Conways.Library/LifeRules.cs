﻿namespace Conway.Library
{
    public enum CellState
    {
        Alive,
        Dead,
    }

    public class LifeRules
    {
        public static CellState GetNewState(CellState currentState, int liveNeighbors)
        {
            switch (currentState)
            {
                case CellState.Alive:
                    if (liveNeighbors < 2 || liveNeighbors > 3)
                        return CellState.Dead;
                    break;
                case CellState.Dead:
                    if (liveNeighbors == 3)
                        return CellState.Alive;
                    break;
                default:
                    break;
            }
            return currentState;
        }
    }
}
