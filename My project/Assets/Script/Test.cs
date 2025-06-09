using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private string name = "이유경";
    private int age = 26;
    private string MBTI = "INFJ";
    private float height = 158.5f;
    private string fruit = "참외";
    
    private int lucky_num;
    private string star = "천칭자리";
    private char blood_type = 'A';
    private string like_game = "젤다의 전설 시리즈";
    private double switch2_price = 648000;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("안녕하세요");
        //Debug.Log("반갑습니다");
        //Debug.Log("한번만 실행됩니다.");

        //print(Random.Range(1, 100));
        // 1 이상 100 미만의 랜덤한 값을 만들어 낸다

        SelfIntroduceName(name, age, MBTI, height, fruit);
        Etc(lucky_num, star, blood_type, like_game, switch2_price);
    }

    public void SelfIntroduceName(string name, int age, string MBTI, float height, string fruit)
    {
        Debug.Log("제 이름은 " + name + "입니다.\n");
        Debug.Log("제 나이는 " + age + "입니다.\n");
        Debug.Log("제 MBTI는 " + MBTI + "입니다.\n");
        Debug.Log("제 키는 " + height + "입니다.\n");
        Debug.Log("가장 좋아하는 과일은 " + fruit + "입니다.\n");
    }

    public void Etc(int lucky_num, string star, char blood_type, string like_game, double switch2_price)
    {
        lucky_num = Random.Range(1, 100);
        Debug.Log("오늘 제 행운의 숫자는 " + lucky_num + "입니다.\n");
        Debug.Log("제 별자리는 " + star + "입니다.\n");
        Debug.Log("제 혈액형은 " + blood_type + "입니다.\n");
        Debug.Log("제가 가장 좋아하는 게임은 " + like_game + "입니다.\n");
        Debug.Log("닌텐도 스위치 2 가격은 " + switch2_price + "입니다.\n");
     }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("매 프레임마다 여러번 실행됩니다.");
    }
    void Awake()
    {
        //Debug.Log("최초 한번만 실행됩니다.");
    }

    void OnEnable()
    {
        //Debug.Log("활성화 될 때 실행됩니다.");
    }
}
