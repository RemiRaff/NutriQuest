using UnityEngine;
using TNRD;

// Handles player input
public class PlayerController : MonoBehaviour
{
    [SerializeField] private SerializableInterface<IMove> m_playerMoveInterface;
    [SerializeField] private SerializableInterface<IJump> m_playerJumpInterface;

    private IMove m_playerMove => m_playerMoveInterface.Value;
    private IJump m_playerJump => m_playerJumpInterface.Value;

    // Move variables
    private float horizontalInput;
    private float verticalInput;

    // Input in Update    
    void Update()
    {
        // Jump input (old input system)
        if (Input.GetButtonDown("Jump"))
        {
            m_playerJump.Jump();
        }

        // Move input (old input system)
        horizontalInput = Input.GetAxis("Horizontal"); // Right and left
        verticalInput = Input.GetAxis("Vertical"); // Background and foreground
    }

    // FixedUpdate for Rigidbody movement
    void FixedUpdate()
    {
         m_playerMove.Move(new Vector2(horizontalInput, verticalInput));
    }
}
