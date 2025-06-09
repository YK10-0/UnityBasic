using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialog_Script : MonoBehaviour
{
    public TextMeshProUGUI text_test;
    public string NextText;
    public Button Text_Btn;

    // Start is called before the first frame update
    void Start()
    {
        Text_Btn.onClick.AddListener(OnClickButton);
    }
    public void OnClickButton()
    {
        NextText = "다음 대사입니다.";
        text_test.text = NextText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
