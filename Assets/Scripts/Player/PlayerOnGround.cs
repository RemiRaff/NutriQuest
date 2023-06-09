using UnityEngine;

public class PlayerOnGround : MonoBehaviour, IGrounded
{
    [SerializeField]
    float m_maxDistance;
    [SerializeField]
    LayerMask m_groundLayerMask;

    /* void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, m_boxSize);
    }*/

    /*void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down, Color.red);
    }*/

    public bool IsGrounded()
    {
        // transform.position at zero makes issue on ground detection
        Ray ray = new Ray(transform.position, Vector3.down);
        bool hit = Physics.Raycast(ray, m_maxDistance, m_groundLayerMask);

        return hit;
        /* BoxCast, OverlapBox
        if (Physics.OverlapBox(transform.position, m_boxSize, transform.rotation, m_groundLayerMask)) // -transform.up, 
            m_grounded = true;
        else
            m_grounded = false;
        return m_grounded;*/
    }
}
