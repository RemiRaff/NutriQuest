using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour, IJump
{
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float m_jumpForce = 20f;

    private bool m_inair = false;
    // Start is called before the first frame update
    public void Jump()
    {
        if (IsGrounded())
        {
            Debug.Log("Jumping...");
            m_rigidbody.AddForce(0f, m_jumpForce, 0f);
            Debug.Log("End jump...");
        }
    }

    public bool IsJumping()
    {
        return m_inair;
    }

    public bool IsGrounded()
    {
        return !m_inair;
    }
}
