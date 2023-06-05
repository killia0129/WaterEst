using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    [Header("�ړ��֌W")]
    [Tooltip("�v���C���[�̑��x")][SerializeField] float speed;
    [Tooltip("�v���C���[�̐��񑬓x")][SerializeField] float RotAngle;
    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (v > 0)
        {
            rb.AddForce(transform.forward * speed, ForceMode.Force);
        }
        if(h>0)
        {
            transform.Rotate(new Vector3(0, RotAngle, 0));
        }
        else if(h<0)
        {
            transform.Rotate(new Vector3(0, -RotAngle, 0));
        }
    }
}
