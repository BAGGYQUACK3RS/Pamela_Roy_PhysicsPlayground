using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] GameObject ballSpawn;
    [SerializeField] PlayerControl playerInput;
    public float spawnDelay = 2.0f;
    Rigidbody2D ball;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ball = collision.gameObject.GetComponentInParent<Rigidbody2D>();

        DeactivateBall();
        playerInput.flippersActive = false;
    }

    void DeactivateBall()
    {
        if (ball != null)
        {
            // Stop the ball's velocity before repositioning it.
            ball.linearVelocity = Vector2.zero;
            ball.angularVelocity = 0;
            ball.transform.rotation = Quaternion.identity;
            ball.bodyType = RigidbodyType2D.Kinematic;
            ball.gameObject.transform.position = ballSpawn.transform.position;

            ball.gameObject.SetActive(false);
        }
    }

    public void ReactivateBall()
    {   
        float timeStamp = Time.time;
        if (Time.time > timeStamp + spawnDelay)
        {
            ball.gameObject.SetActive(true);
            ball.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}