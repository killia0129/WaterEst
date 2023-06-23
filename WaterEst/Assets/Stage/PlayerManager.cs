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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i=1;i<4;i++)
        {
            switch (i)
            {
                case 0:
                    player[i] = Player1.playerPos;
                    break;

                case 1:
                    player[i] = Player2.playerPos;
                    break;

                case 2:
                    player[i] = Player3.playerPos;
                    break;

                case 3:
                    player[i] = Player4.playerPos;
                    break;
            }
        }
    }
}
