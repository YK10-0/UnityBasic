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
        // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        // ������ 70% Ȯ���� 'ġġ'�� �̾ƹ��ȴ�!

        int randomValue = UnityEngine.Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        Debug.Log($"������ ���� : {randomValue} �Դϴ�");
        // count 81
        if (8 <= count)
        {
            Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
            count = 0;
        }
        else if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'��û'�� �̾Ҵ�!");
        }
        else if (randomValue <= 30) // 11 ~ 30
        {
            Debug.Log("'��'�� �̾Ҵ�!");
        }
        else
        {
            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
        }

        count++;
    }

    public void GachaSwitch()
    {
        // 
        int randomValue = UnityEngine.Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe)
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
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
                Debug.Log("'����'�� �̾ҽ��ϴ�!");
            }
            else if (num > 10 && num <= 30)
            {
                Debug.Log("'�ƽ�Ʈ��'�� �̾ҽ��ϴ�!");
            }
            else
            {
                Debug.Log("'����ȣ'�� �̾ҽ��ϴ�!");
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
                Debug.Log("'����'�� �̾ҽ��ϴ�!");
            }
            else if (num > 10 && num <= 30)
            {
                Debug.Log("'�ƽ�Ʈ��'�� �̾ҽ��ϴ�!");
            }
            else
            {
                Debug.Log("'����ȣ'�� �̾ҽ��ϴ�!");
            }
            count++;
        }
    }
}
