using UnityEngine;

public class GroupTrigger : MonoBehaviour
{
    [SerializeField] float delayTime;
    private float timeStamp;
    public bool areActive;

    void Start()
    {
        areActive = true;
    }

    void Update()
    {
        if (Time.time > timeStamp + delayTime)
        {
            areActive = true;
        }
    }

    public void DeactivateGroup(float index)
    {
        areActive = false;
        timeStamp = index;
    }
}
