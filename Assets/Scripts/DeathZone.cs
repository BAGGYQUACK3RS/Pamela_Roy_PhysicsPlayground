using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] GameObject ballSpawn;
    [SerializeField] PlayerControl playerInput;
    [SerializeField] BallController ballControl;
    public float spawnDelay = 2.0f;
    Rigidbody2D ball;
    private bool isOut = false;
    private float timeStamp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ball = collision.gameObject.GetComponentInParent<Rigidbody2D>();

        isOut = true;
        ballControl.DeactivateBall();
        playerInput.flippersActive = false;
        
        timeStamp = Time.time;
    }

    void Update() {
        if (Time.time > timeStamp + spawnDelay || isOut)
        {
            isOut = false;
            ballControl.RepositionBall(ballSpawn.transform.position);
        }
    }
}