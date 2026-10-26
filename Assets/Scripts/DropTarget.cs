using System;
using System.Text.RegularExpressions;
using UnityEngine;

public class DropTarget : MonoBehaviour
{
    [SerializeField] CircleCollider2D circleCollider;
    [SerializeField] GroupTrigger groupTrigger;
    private float timeStamp;
    private SpriteRenderer[] renderers;

    void Start()
    {
        renderers = GetComponentsInChildren<SpriteRenderer>();
    }

    void TurnOff()
    {
        circleCollider.enabled = false;
        foreach (SpriteRenderer rend in renderers)
        {
            Color c = rend.color;
            c.a = 0.5f;
            rend.color = c;
        }
    }

    void TurnOn()
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

    void Update()
    {
        if (groupTrigger.areActive == true)
        {
            TurnOn();
        } else if(groupTrigger.areActive == false)
        {
            TurnOff();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timeStamp = Time.time;
        groupTrigger.DeactivateGroup(timeStamp);
    }
}