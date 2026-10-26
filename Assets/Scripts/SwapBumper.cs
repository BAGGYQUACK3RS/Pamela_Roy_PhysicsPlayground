using System.IO.Compression;
using UnityEngine;

public class SwapBumper : MonoBehaviour
{
    [SerializeField] GameObject left, right, trigger;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Position of the pinball minus the bumper position gives me a Vector from the bumper toward the pinball.
        left.SetActive(!left.activeSelf);
        right.SetActive(!right.activeSelf);
    }
}