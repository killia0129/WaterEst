using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SwitchSystem : MonoBehaviour
{
    float bottomY = 0.6f;
    float speed = 0.5f;

    bool active;
    [SerializeField] private WaterShot WaterShotScript;
    [SerializeField] private ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(active && transform.position.y > bottomY)
        {
            transform.position -= Vector3.up*speed*Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!active && other.CompareTag("player"))
        {
            active = true;
        }
    }
}
