using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private string name = "������";
    private int age = 26;
    private string MBTI = "INFJ";
    private float height = 158.5f;
    private string fruit = "����";
    
    private int lucky_num;
    private string star = "õĪ�ڸ�";
    private char blood_type = 'A';
    private string like_game = "������ ���� �ø���";
    private double switch2_price = 648000;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("�ȳ��ϼ���");
        //Debug.Log("�ݰ����ϴ�");
        //Debug.Log("�ѹ��� ����˴ϴ�.");

        //print(Random.Range(1, 100));
        // 1 �̻� 100 �̸��� ������ ���� ����� ����

        SelfIntroduceName(name, age, MBTI, height, fruit);
        Etc(lucky_num, star, blood_type, like_game, switch2_price);
    }

    public void SelfIntroduceName(string name, int age, string MBTI, float height, string fruit)
    {
        Debug.Log("�� �̸��� " + name + "�Դϴ�.\n");
        Debug.Log("�� ���̴� " + age + "�Դϴ�.\n");
        Debug.Log("�� MBTI�� " + MBTI + "�Դϴ�.\n");
        Debug.Log("�� Ű�� " + height + "�Դϴ�.\n");
        Debug.Log("���� �����ϴ� ������ " + fruit + "�Դϴ�.\n");
    }

    public void Etc(int lucky_num, string star, char blood_type, string like_game, double switch2_price)
    {
        lucky_num = Random.Range(1, 100);
        Debug.Log("���� �� ����� ���ڴ� " + lucky_num + "�Դϴ�.\n");
        Debug.Log("�� ���ڸ��� " + star + "�Դϴ�.\n");
        Debug.Log("�� �������� " + blood_type + "�Դϴ�.\n");
        Debug.Log("���� ���� �����ϴ� ������ " + like_game + "�Դϴ�.\n");
        Debug.Log("���ٵ� ����ġ 2 ������ " + switch2_price + "�Դϴ�.\n");
     }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("�� �����Ӹ��� ������ ����˴ϴ�.");
    }
    void Awake()
    {
        //Debug.Log("���� �ѹ��� ����˴ϴ�.");
    }

    void OnEnable()
    {
        //Debug.Log("Ȱ��ȭ �� �� ����˴ϴ�.");
    }
}
