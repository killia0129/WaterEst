using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private PlayerPos Player1;
    [SerializeField] private PlayerPos Player2;
    [SerializeField] private PlayerPos Player3;
    [SerializeField] private PlayerPos Player4;
    
    int[] player = new int[4];

    int posCom0;
    int posCom1;
    int posCom2;
    int posCom3;
    int max;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player[0] = Player1.playerPos;
        player[1] = Player2.playerPos;
        player[2] = Player3.playerPos;
        player[3] = Player4.playerPos;

        for (int i=1;i<4;i++)
        {
            if (player[i] == 0)
            {
                posCom0 += 1;
            }
            if (player[i] == 1)
            {
                posCom1 += 1;
            }
            if (player[i] == 2)
            {
                posCom2 += 1;
            }
            if (player[i] == 3)
            {
                posCom3 += 1;
            }
        }
    }
}
