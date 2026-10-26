using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] GameObject ballSpawn;
    [SerializeField] PlayerControl playerInput;
    [SerializeField] BallController ballControl;
    [SerializeField] float spawnDelay = 2.0f;
    private bool isOut = false;
    private float timeStamp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isOut = true;
        ballControl.Deactivate();
        playerInput.flippersActive = false;
        
        timeStamp = Time.time;
    }

    void Update() {
        if (Time.time > timeStamp + spawnDelay && isOut)
        {
            isOut = false;
            ballControl.Show();
            ballControl.Reposition(ballSpawn.transform.position);
        }
    }
}