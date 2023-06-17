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

    float repeatSpan = 8;
    float waterStopElapsedTime = 0;
    float bottomPosY;
    bool switchReset;
    // Start is called before the first frame update
    void Start()
    {
        repeatSpan = 7;
        waterStopElapsedTime = 0;
        bottomPosY = transform.position.y;
        switchReset = false;
    }

    // Update is called once per frame
    void Update()
    { 
        if (active && transform.position.y > bottomY)
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
           
        }
        if (active)
        {
            WaterShotScript.waterActive = false;
            switchReset = false;
            waterStopElapsedTime += Time.deltaTime;
        }
        if(waterStopElapsedTime >= repeatSpan)          //‰Ÿ‚³‚ê‚½ó‘Ô‚©‚çŒ³‚É–ß‚·
        {
            active = false;
            WaterShotScript.waterActive = true;
            waterStopElapsedTime = 0;
            switchReset = true;
        }
        if (active == false && transform.position.y < bottomPosY&&switchReset == true)  
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
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
