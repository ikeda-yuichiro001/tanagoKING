using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class titlesystem : MonoBehaviour
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
    public void OnClick(int nunber)
    {
        switch (nunber)
        {
            case 0:
                SceneManager.LoadScene("select");
                break;
            case 1:
                SceneManager.LoadScene("option");
                break;
            case 2:
                SceneManager.LoadScene("gallery");
                break;
            default:
                break;
        }
    }
}
