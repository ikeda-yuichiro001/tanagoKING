using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        //わからんからとりあえず変数宣言
        int point1;

        point1 = 0;


        //方向キー下
        if (point1 == 0 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            point1 = 1;

        }
        if (point1 == 1 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            point1 = 2;

        }
        if (point1 == 2 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            point1 = 3;

        }
        if (point1 == 3 && Input.GetKeyDown(KeyCode.UpArrow))
        {
            point1 = 0;

        }

        //方向キー上
        if (point1 == 0 && Input.GetKeyDown(KeyCode.UpArrow))
        {
            point1 = 3;

        }
        if (point1 == 1 && Input.GetKeyDown(KeyCode.UpArrow))
        {
            point1 = 0;

        }
        if (point1 == 2 && Input.GetKeyDown(KeyCode.UpArrow))
        {
            point1 = 1;

        }
        if (point1 == 3 && Input.GetKeyDown(KeyCode.UpArrow))
        {
            point1 = 2;

        }

        //方向キー左右
        if (point1 <= 2  && Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            point1 = 3;

        }
        if (point1 == 3 && Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            point1 = 0;

        }//シーン移動(一時的に３と０の結果を入れ替える)
        if (point1 == 3 && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("nurturing");
        }
        if (point1 == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("off-line");
        }
        if (point1 == 2 && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("on-line");
        }
        if (point1 == 0 && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("title");
        }

        //if (point1 == 0 && )
        {

        }
        //if (point1 == 1 && )
        {

        }
        //if (point1 == 2 && )
        {

        }
        //if (point1 == 3 && )
        {

        }


    }
}
