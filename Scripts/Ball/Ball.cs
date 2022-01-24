using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private IEnumerable<IBallHandler> _handlers;

    public void Initialize(BallConfiguration configuration, IEnumerable<IBallHandler> handlers)
    {
        _handlers = handlers;
    }

    private void OnMouseDown()
    {
        NotifyHandlers(BallState.Caught);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Abyss _))
            NotifyHandlers(BallState.Uncaught);

        Destroy(gameObject);
    }

    private void NotifyHandlers(BallState ballState)
    {
        foreach (var handler in _handlers)
            handler.OnEvent(ballState);
    }
}