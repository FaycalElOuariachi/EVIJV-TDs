using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject m_Ball1;
    public GameObject m_Ball2;

    private Vector3 m_Offset;

    // Use this for initialization
    void Start()
    {
        m_Offset = transform.position - FindAveragePosition();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = FindAveragePosition() + m_Offset;
    }

    private Vector3 FindAveragePosition()
    {
        return (m_Ball1.transform.position + m_Ball2.transform.position) / 2;
    }
}
