using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] Rigidbody2D ball;

    void DeactivateBall()
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

    public void ReactivateBall()
    {   
        if (ball != null)
        {
            ball.gameObject.SetActive(true);
            ball.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
