using UnityEngine;

public class LivesCounter : MonoBehaviour, IBallHandler
{
    private int _currentValue;

    public void Initialize(LivesConfiguration configuration)
    {
        _currentValue = configuration.MaximumValue;
    }

    public void OnEvent(BallState ballState)
    {
        if (ballState.Equals(BallState.Uncaught))
            _currentValue--;
    }
}