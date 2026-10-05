using UnityEngine;

public class Portals : MonoBehaviour
{
    [SerializeField] Transform exitPoint;
    [SerializeField] float delayTime = 0.5f;
    static float lastTeleportTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Time.time < lastTeleportTime + delayTime)
            return;

        Rigidbody2D ball = collision.gameObject.GetComponentInParent<Rigidbody2D>();

        if (ball != null && exitPoint != null)
        {
            lastTeleportTime = Time.time;

            ball.transform.position = exitPoint.position;
        }
    }
}