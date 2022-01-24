using UnityEngine;

public class ScoreCounter : MonoBehaviour, IBallHandler
{
    private int _currentValue;

    public void Initialize()
    {

    }

    public void OnEvent(BallState ballState)
    {
        if (ballState.Equals(BallState.Caught))
            _currentValue++;
    }
}