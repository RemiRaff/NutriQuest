using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TNRD;

// Handles player input
public class PlayerController : MonoBehaviour
{
    [SerializeField] private SerializableInterface<IMove> m_playerMoveInterface;
    [SerializeField] private SerializableInterface<IJump> m_playerJumpInterface;

    private IMove m_playerMove => m_playerMoveInterface.Value;
    private IJump m_playerJump => m_playerJumpInterface.Value;


    // FixedUpdate for Rigidbody movement
    void FixedUpdate()
    {
        // Jump input (old input system)
        bool jumpInput = Input.GetButtonDown("Jump");
        if (jumpInput)
        {
            m_playerJump.Jump();
        }

        // Move input (old input system)
        float horizontalInput = Input.GetAxis("Horizontal"); // Right and left
        float verticalInput = Input.GetAxis("Vertical"); // Background and foreground
        m_playerMove.Move(new Vector2(horizontalInput, verticalInput));
    }
}
