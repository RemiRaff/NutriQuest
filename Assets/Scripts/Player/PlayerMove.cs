using UnityEngine;

// Moves the player character
public class PlayerMove : MonoBehaviour, IMove
{
    // Freeze Rotation in X for rb in Inspector
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float m_speed = 20f;

    // [SerializeField] PlayerAnimations m_playerAnimations;

    // Implements IMove interface method
    public void Move(Vector2 input_v2)
    {
        // Move the player
        Vector3 direction = new Vector3(input_v2.x, 0, input_v2.y);
        m_rigidbody.velocity = direction * m_speed + m_rigidbody.velocity.y * Vector3.up;

        // m_playerAnimations.Move(direction.magnitude);

        // Rotate the player
        if (direction != Vector3.zero)
        {
            m_rigidbody.rotation = Quaternion.LookRotation(direction);
        }
    }
}
