using UnityEngine;
using TNRD;

public class PlayerJump : MonoBehaviour, IJump
{
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private SerializableInterface<IGrounded> m_playerGroundedInterface;
    [SerializeField] private float m_jumpForce = 350f; // TODO: à mettre dans un scriptable object pour le player ???
    [SerializeField] private float m_jumpDelta = 10; // TODO: à mettre dans un scriptable object pour le player ???
    [SerializeField] private float m_jumpNiv = 0; // TODO: à mettre dans un scriptable object pour le player ???

    private IGrounded m_playerGrounded => m_playerGroundedInterface.Value;

    // Start is called before the first frame update
    public void Jump()
    {
        if (m_playerGrounded.IsGrounded())
        {
            m_rigidbody.AddForce(transform.up * JumpForce(), ForceMode.Impulse);
        }
    }

    // Calculate the jump force
    private float JumpForce()
    {
        return m_jumpForce + m_jumpDelta * m_jumpNiv;
    }
}
