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
    // 심화: 업다운
    // 랜덤한 수 1~100 사이 값을 만들고
    // Input Field에 입력된 값이
    // 랜덤한 값보다 크면 크다, 작으면 작다.
    // Count 증가
    // 결과적으로 몇 번만에 답을 맞히는지.
    public TextMeshProUGUI result;
    Boolean chk2 = true;
    List<string> characterList = new List<string>
        {
            "S: 의현",
            "A: 반인호",
            "A: 펄크라",
            "B: 장비 아이템 1",
            "B: 장비 아이템 2",
            "B: 장비 아이템 3",
            "B: 장비 아이템 4",
            "B: 장비 아이템 5",
            "B: 장비 아이템 6",
            "B: 장비 아이템 7"
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

        result.text = ""; // 출력 초기화
        a = 0;   // 인덱스 초기화
        chk = true;       // 다시 출력 시작 가능
    }
    public void Listtest()
    {
        if (chk == true)
        {

            //데이터 출력용
            if (chk && a < gacha_result.Length)
            {
                result.text += $"가챠 결과 {a + 1}번째: {gacha_result[a]}\n";
                a++;

                if (a == gacha_result.Length)
                {
                    chk = false; // 모두 출력되면 멈춤
                }
            }
            // 한번에 가챠 돌림 + 버튼을 누를 때마다 하나씩 결과가 나오게끔 함.
        }
    }
    public void OnClickButton()
    {
        Listtest();
    }
}