﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class selectsystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonClick()
    {
        EditorApplication.Beep();
    }

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick(int nunber_)
    {
        switch (nunber_)
        {
            case 0:
                SceneManager.LoadScene("ikusei");
                break;
            case 1:
                SceneManager.LoadScene("off-line");
                break;
            case 2:
                SceneManager.LoadScene("on-line");
                break;
            case 3:
                SceneManager.LoadScene("title");
                break;
            default:
                break;
        }
    }
}
