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
    // Start is called before the first frame update
    void Start()
    {
        repeatSpan = 7;
        waterStopElapsedTime = 0;
        bottomPosY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        waterStopElapsedTime += Time.deltaTime;
        if (active && transform.position.y > bottomY)
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }
        if (active)
        {
            WaterShotScript.waterActive = false;
        }
        if(waterStopElapsedTime >= repeatSpan)          //押された状態から元に戻す
        {
            active = false;
            WaterShotScript.waterActive = true;
            waterStopElapsedTime = 0;
        }
        if(active == false && transform.position.y < bottomPosY)    //★押すタイミングによって戻る速さが変わるバグを直す
        {
         transform.position += Vector3.up * speed * Time.deltaTime;
        }

        Debug.Log(waterStopElapsedTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!active && other.CompareTag("player"))
        {
            active = true;
        }
    }
}
