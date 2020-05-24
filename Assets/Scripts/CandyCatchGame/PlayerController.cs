using UnityEngine;

namespace Scripts.CandyCatchGame
{
    public class PlayerController : MonoBehaviour
    {
        private bool _canMove => !GameManager.Shared.IsGameOver;

        [SerializeField] private float MaxPos;

        [SerializeField] private float MoveSpeed;

        private void Update()
        {
            if (_canMove) Move();
        }

        private void Move()
        {
            var xMovement = Input.GetAxis("Horizontal");

            var position = transform.position;
            position += Vector3.right * (xMovement * MoveSpeed * Time.deltaTime);

            var clampedPosX = Mathf.Clamp(position.x, -MaxPos, MaxPos);
            position.x = clampedPosX;

            transform.position = position;
        }
    }
}