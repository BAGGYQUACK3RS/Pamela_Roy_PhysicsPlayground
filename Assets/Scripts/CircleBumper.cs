using UnityEngine;

public class CircleBumper : MonoBehaviour
{
    [SerializeField] SpriteRenderer rend;
    [SerializeField] GameObject outer;
    float timeStamp;
    [SerializeField] float delayTime;

    [SerializeField] float forceValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeStamp + delayTime)
        {
            rend.color = new Color(0f/255f, 123f/255f, 32f/255f);
            outer.transform.localScale = new Vector3(2f, 2f, 0);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timeStamp = Time.time;
        rend.color = Random.ColorHSV();
        outer.transform.localScale = new Vector3(2.2f, 2.2f, 0);

        // Position of the pinball minus the bumper position gives me a Vector from the bumper toward the pinball.
        Vector2 direction = (collision.transform.position - transform.position).normalized;

        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

        rb.AddForce(direction * forceValue, ForceMode2D.Impulse);
    }
}