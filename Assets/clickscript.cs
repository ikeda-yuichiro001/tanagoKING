﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
public class clickscript : MonoBehaviour
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
        public void OnClick()
        {
          SceneManager.LoadScene("select");
        }
    
}