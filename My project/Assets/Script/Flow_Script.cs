using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class Flow_Script : MonoBehaviour
{
    int count;
    public Button GachaBtn;
    Boolean chk = false;

    private void Awake()
    {
        count = 0;
    }

    void Start()
    {
        GachaBtn.onClick.AddListener(OnClickButton);
        Gacha_Result_Save();
    }
    // ��ȭ: ���ٿ�
    // ������ �� 1~100 ���� ���� �����
    // Input Field�� �Էµ� ����
    // ������ ������ ũ�� ũ��, ������ �۴�.
    // Count ����
    // ��������� �� ������ ���� ��������.
    public TextMeshProUGUI result;
    Boolean chk2 = true;
    List<string> characterList = new List<string>
        {
            "S: ����",
            "A: ����ȣ",
            "A: ��ũ��",
            "B: ��� ������ 1",
            "B: ��� ������ 2",
            "B: ��� ������ 3",
            "B: ��� ������ 4",
            "B: ��� ������ 5",
            "B: ��� ������ 6",
            "B: ��� ������ 7"
        };
    string[] gacha_result = new string[10];
    int a = 0;

    public void Gacha_Result_Save()
    {
        for (int i = 0; i < 10; i++)
        {
            int num = UnityEngine.Random.Range(0, characterList.Count);
            gacha_result[i] = characterList[num];
        }

        result.text = ""; // ��� �ʱ�ȭ
        a = 0;   // �ε��� �ʱ�ȭ
        chk = true;       // �ٽ� ��� ���� ����
    }
    public void Listtest()
    {
        if (chk == true)
        {

            //������ ��¿�
            if (chk && a < gacha_result.Length)
            {
                result.text += $"��í ��� {a + 1}��°: {gacha_result[a]}\n";
                a++;

                if (a == gacha_result.Length)
                {
                    chk = false; // ��� ��µǸ� ����
                }
            }
            // �ѹ��� ��í ���� + ��ư�� ���� ������ �ϳ��� ����� �����Բ� ��.
        }
    }
    public void OnClickButton()
    {
        Listtest();
    }
}