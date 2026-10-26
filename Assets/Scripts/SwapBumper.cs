using System.IO.Compression;
using UnityEngine;

public class SwapBumper : MonoBehaviour
{
    [SerializeField] GameObject left, right, trigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        left.SetActive(!left.activeSelf);
        right.SetActive(!right.activeSelf);
    }
}