// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class followCamera : MonoBehaviour
// {
//     public Transform player;
//     public Vector3 offset;

//     void Update(){
//         transform.position= player.position + offset;
//     }
// }
using UnityEngine;
using System.Collections;

public class followCamera : MonoBehaviour
{

    //offset from the viewport center to fix damping
    public float m_DampTime = 10f;
    public Transform m_Target;
    public float xInitial;
    public float yInitial;
    public float xFinal;
    public float yFinal;

    void Start()
    {
        if (m_Target == null)
        {
            m_Target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {

        transform.position = new Vector3(Mathf.Clamp(m_Target.position.x, xInitial, xFinal), Mathf.Clamp(m_Target.position.y, yInitial, yFinal), -10);
    }
}