using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    private Transform m_PlayerTransform;

    [SerializeField]
    private Vector3 m_offset;
 
    [SerializeField]
    private float m_RotationSpeed = 10;
    #endregion

    #region Main Updates
    private void LateUpdate()
    {
        Vector3 newPos = m_PlayerTransform.position + m_offset;
        transform.position = Vector3.Slerp(transform.position, newPos, 1);
        float rotationAmount = m_RotationSpeed * Input.GetAxis("Mouse X");
        transform.RotateAround(m_PlayerTransform.position, Vector3.up, rotationAmount);

        m_offset = transform.position - m_PlayerTransform.position;
    }
    #endregion
}
