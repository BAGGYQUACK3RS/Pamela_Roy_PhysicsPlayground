using UnityEngine;

public class DropTarget : MonoBehaviour
{
    private SpriteRenderer[] renderers;
    float timeStamp;
    [SerializeField] float delayTime;
    [SerializeField] private CircleCollider2D circleCollider;

    void Start()
    {
        renderers = GetComponentsInChildren<SpriteRenderer>();
    }

    void Update()
    {
        if (renderers.Length > 0 && Time.time > timeStamp + delayTime)
        {
            circleCollider.enabled = true;
            if (renderers[0].color.a == 0.5f)
            {
                foreach (SpriteRenderer rend in renderers)
                {
                    Color c = rend.color;
                    c.a = 1f;
                    rend.color = c;
                }
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timeStamp = Time.time;
        circleCollider.enabled = false;
        foreach (SpriteRenderer rend in renderers)
        {
            Color c = rend.color;
            c.a = 0.5f;
            rend.color = c;
        }
    }
}