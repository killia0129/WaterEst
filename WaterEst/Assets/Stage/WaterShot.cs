using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterShot : MonoBehaviour
{
    private float repeatSpan;    //�Đ��J��Ԃ��Ԋu
    private float playElapsedTime;   //�Đ��o�ߎ���
    private float stopElapsedTime;   //��~�o�ߎ���
    int rand;
    private float shotSpan;         //�V���b�g�Ԋu
    private float shotElapsedTime;  //�V���b�g�o�ߎ���
    [SerializeField] private ParticleSystem particle;

    bool waterActive;
    // Start is called before the first frame update
    void Start()
    {
        repeatSpan = 3;    //�Đ��Ԋu��ݒ�
        playElapsedTime = 0;   //�Đ��o�ߎ��Ԃ����Z�b�g
        stopElapsedTime = 0;    //��~�o�ߎ��Ԃ����Z�b�g

        shotSpan = 5;   //�V���b�g�Ԋu��ݒ�
        shotElapsedTime = 0; //�V���b�g�o�ߎ��Ԃ����Z�b�g
    }

    // Update is called once per frame
    void Update()
    {
        shotElapsedTime += Time.deltaTime;  //�V���b�g�o�ߎ��Ԃ��J�E���g
        if (shotElapsedTime >= shotSpan)
        {
            rand = Random.Range(1, 2);  //�����_���P�`�S
            if (rand == 1)              //1���o���琅������
            {
                waterActive = true;
                Play();
            }
            shotElapsedTime = 0;        //�V���b�g�o�ߎ��Ԃ����Z�b�g
        }
        //Debug.Log(shotElapsedTime);     //���f�o�b�O�p
    }

    // 1. �Đ�
    public void Play()
    {
        playElapsedTime += Time.deltaTime;     //�Đ��o�ߎ��Ԃ��J�E���g
        stopElapsedTime += Time.deltaTime;     //��~�o�ߎ��Ԃ��J�E���g
        if (playElapsedTime <= repeatSpan && stopElapsedTime <= repeatSpan)
        {
            particle.Play();
            playElapsedTime = 0;   //�Đ��o�ߎ��Ԃ����Z�b�g����
        }
    }

    // 2. �ꎞ��~
    public void Pause()
    {
        particle.Pause();
    }

    // 3. ��~
    public void Stop()
    {
        particle.Stop();
    }
    private void OnParticleSystemStopped()
    {
        Debug.Log("stop!");
    }
}
