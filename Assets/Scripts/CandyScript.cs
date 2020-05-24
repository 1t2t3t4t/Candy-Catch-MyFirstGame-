using Scripts.Constant;
using UnityEngine;

namespace Scripts
{
    public class CandyScript : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(Tag.Player))
            {
                GameManager.Shared.IncreaseScore();
                Destroy(gameObject);
            }
            else if (other.gameObject.CompareTag(Tag.Boundary))
            {
                GameManager.Shared.DecreaseLife();
                Destroy(gameObject);
            }
        }
    }
}