using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int count;
    private void Awake()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Gacha()
    {
        // 확률이 10%면 로그에 '각청'을 뽑았다!
        // 확률이 20%면 로그에 '모나'를 뽑았다!
        // 나머지 70% 확률로 '치치'를 뽑아버렸다!

        int randomValue = UnityEngine.Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        Debug.Log($"랜덤한 값은 : {randomValue} 입니다");
        // count 81
        if (8 <= count)
        {
            Debug.Log("확정으로 '각청'을 뽑았다!");
            count = 0;
        }
        else if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'각청'을 뽑았다!");
        }
        else if (randomValue <= 30) // 11 ~ 30
        {
            Debug.Log("'모나'을 뽑았다!");
        }
        else
        {
            Debug.Log("'치치'를 뽑아버렸다!");
        }

        count++;
    }

    public void GachaSwitch()
    {
        // 
        int randomValue = UnityEngine.Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe)
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                }
                break;
        }
    }

    public void GachaFor()
    {

        for (int i = 0; i <= 10; i++)
        {
            int num = UnityEngine.Random.Range(1, 101);
            if (num <= 10)
            {
                Debug.Log("'의현'을 뽑았습니다!");
            }
            else if (num > 10 && num <= 30)
            {
                Debug.Log("'아스트라'를 뽑았습니다!");
            }
            else
            {
                Debug.Log("'반인호'를 뽑았습니다!");
            }
        }
    }

    public void GachaWhile()
    {
        int count = 0;
        while (count <= 10)
        {
            int num = UnityEngine.Random.Range(1, 101);
            if (num <= 10)
            {
                Debug.Log("'의현'을 뽑았습니다!");
            }
            else if (num > 10 && num <= 30)
            {
                Debug.Log("'아스트라'를 뽑았습니다!");
            }
            else
            {
                Debug.Log("'반인호'를 뽑았습니다!");
            }
            count++;
        }
    }
}
