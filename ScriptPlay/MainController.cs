using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainController : MonoBehaviour
{
   
   //string name = "PlayGame";
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            SceneManager.LoadScene("playgame");
        }
        else if(Input.GetKey(KeyCode.Joystick1Button1))
            {
            Application.Quit();
        }

    }

    /*public void SceneChange(string name)
    {
        SceneManager.LoadScene(name);
    }*/
   
}
