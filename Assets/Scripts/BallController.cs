using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] Rigidbody2D ball;

    public void Deactivate()
    {
        if (ball != null)
        {
            ball.linearVelocity = Vector2.zero;
            ball.angularVelocity = 0;
            ball.transform.rotation = Quaternion.identity;
            ball.bodyType = RigidbodyType2D.Kinematic;

            ball.gameObject.SetActive(false);
        }
    }

    public void Show()
    {   
        if (ball != null)
        {
            ball.gameObject.SetActive(true);
        }
    }

    public void Activate()
    {   
        if (ball != null)
        {
            ball.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    public void Reposition(Vector2 newPos)
    {
        ball.gameObject.transform.position = newPos;
    }
}
