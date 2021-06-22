using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class optionsystem : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }
    public void ButtonClick()
    {
        EditorApplication.Beep();
    }
    public void OnClick(int nunber_)
    {
        switch (nunber_)
        {
            case 0:
                //ひらがなに変えるプログラム
                break;
            case 1:
                //ふりがな付きに変えるプログラム
                break;
            case 2:
                //漢字オンリーに変えるプログラム
                break;
            case 3:
                SceneManager.LoadScene("title");
                break;
            default:
                break;
        }
    }
}
