using Constant;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Tag.Player))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag(Tag.Boundary))
        {
            Destroy(gameObject);
        }
    }
}