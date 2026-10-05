using UnityEngine;

public class FreezeField : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float freezeDuration = 1.5f;

    void Unfreeze()
    {
        // Restore normal physics behavior
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Vector2 direction = (collision.transform.position - transform.position).normalized;

        rb = collision.gameObject.GetComponent<Rigidbody2D>();

        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0;
        rb.bodyType = RigidbodyType2D.Kinematic;

        Invoke("Unfreeze", freezeDuration);
    }
}