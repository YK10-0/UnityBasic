using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Star_Test : MonoBehaviour
{
    public Button P1;
    public Button P2;
    public Button P3;
    public Button P4;
    public Button P5;

    public TextMeshProUGUI star_ans;

    string star;
    // Start is called before the first frame update
    void Start()
    {
        P1.onClick.AddListener(P1ans);
        P2.onClick.AddListener(P2ans);
        P3.onClick.AddListener(P3ans);
        P4.onClick.AddListener(P4ans);
        P5.onClick.AddListener(P5ans);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Phase1()
    {
        star = string.Empty;

        for (int i = 1; i < 6; i++)
        {
            for (int a = 0; a < i; a ++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        Debug.Log("1Phase\n");
        Debug.Log(star);
    }

    public void P1ans()
    {
        star_ans.text = "";
        Phase1();
        star_ans.text = star;
    }

    public void Phase2()
    {
        star = string.Empty;

        for (int i = 5; i > 0; i--)
        {
            for (int a = 0; a < i; a++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        Debug.Log("2Phase\n");
        Debug.Log(star);
    }

    public void P2ans()
    {
        star_ans.text = "";
        Phase2();
        star_ans.text = star;
    }

    public void Phase3()
    {
        star = string.Empty;

        int star_count = 0;

        for (int loop = 0; loop < 2; loop++)
        {
            if (star_count == 0)
            {
                for (int i = 1; i < 6; i++)
                {
                    for (int a = 0; a < i; a++)
                    {
                        star += "¡Ú";
                    }
                    star += "\n";
                }
                star_count = 1;
            }
            else
            {
                for (int i = 4; i > 0; i--)
                {
                    for (int a = 0; a < i; a++)
                    {
                        star += "¡Ú";
                    }
                    star += "\n";
                }
            }
        }
        Debug.Log("3Phase\n");
        Debug.Log(star);
    }

    public void P3ans()
    {
        star_ans.text = "";
        Phase3();
        star_ans.text = star;
    }

    public void Phase4()
    {
        star = string.Empty;

        int star_count = 1;
        int star_draw = 0;

        for (int loop = 0; loop < 2; loop++)
        {
            if (star_count == 1)
            {
                for (int i = 5; i > 0; i--)
                {
                    for (int a = 1; a < i; a++)
                    {
                        star += "¡¡";
                    }
                    for (star_draw = 6; star_draw > i; star_draw--)
                    {
                        star += "¡Ú";
                    }
                    star += "\n";
                }
                star_count = 0;
            }
            else
            {
                for (int i = 5; i > 0; i--)
                {
                    for (int a = 5; a >= i; a--)
                    {
                        star += "¡¡";
                    }
                    for (star_draw = 1; star_draw < i; star_draw++)
                    {
                        star += "¡Ú";
                    }
                    star += "\n";
                }
            }
        }
        Debug.Log("4Phase\n");
        Debug.Log(star);
    }

    public void P4ans()
    {
        star_ans.text = "";
        Phase4();
        star_ans.text = star;
    }

    public void Phase5()
    {
        star = string.Empty;

        int star_count = 1;
        int star_draw = 0;

        for (int loop = 0; loop < 2; loop++)
        {
            if (star_count == 1)
            {
                for (int i = 5; i > 0; i--)
                {
                    for (int a = 1; a < i; a++)
                    {
                        star += "¡¡";
                    }
                    for (star_draw = 6; star_draw > i; star_draw--)
                    {
                        star += "¡Ú";
                    }
                    for (int b = i; b < 5; b++)
                    {
                        star += "¡Ú";
                    }
                    star += "\n";
                }
                star_count = 0;
            }
            else
            {
                for (int i = 5; i > 0; i--)
                {
                    for (int a = 5; a >= i; a--)
                    {
                        star += "¡¡";
                    }
                    for (star_draw = 1; star_draw < i; star_draw++)
                    {
                        star += "¡Ú";
                    }
                    for (int b = 2; b < i; b++)
                    {
                        star += "¡Ú";
                    }
                    star += "\n";
                }
            }
        }
        Debug.Log("5Phase\n");
        Debug.Log(star);
    }

    public void P5ans()
    {
        star_ans.text = "";
        Phase5();
        star_ans.text = star;
    }
}
