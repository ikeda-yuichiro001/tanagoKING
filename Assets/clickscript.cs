using System.Collections;
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
    public void OnClick(int nunber)
    {
        SceneManager.LoadScene("select");
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
    

