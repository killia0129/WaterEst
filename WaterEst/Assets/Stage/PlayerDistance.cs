using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDistance : MonoBehaviour
{
    [SerializeField] GameObject P1;
    [SerializeField] GameObject P2;
    [SerializeField] GameObject P3;
    [SerializeField] GameObject P4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 P1pos = P1.transform.position;
        Vector3 P2pos = P2.transform.position;
        Vector3 P3pos = P3.transform.position;
        Vector3 P4pos = P4.transform.position;

        float dis1to2 = Vector3.Distance(P1pos, P2pos);
        float dis2to3 = Vector3.Distance(P2pos, P3pos);
        float dis3to4 = Vector3.Distance(P3pos, P4pos);
        float dis4to1 = Vector3.Distance(P4pos, P1pos);
        float dis1to3 = Vector3.Distance(P1pos, P3pos);
        float dis2to4 = Vector3.Distance(P2pos, P4pos);

        Debug.Log(dis1to2);
        Debug.Log(dis2to3); 
        Debug.Log(dis3to4); 
        Debug.Log(dis4to1);
        Debug.Log(dis1to3); 
        Debug.Log(dis2to4); 
    }
}
