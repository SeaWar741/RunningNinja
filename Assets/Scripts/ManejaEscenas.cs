using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejaEscenas : MonoBehaviour
{
    public static void ChangeScene(string scene){
        Debug.Log("Escena seleccionada: "+scene);
        SceneManager.LoadScene(scene);
        if(scene == "Salir"){
            Application.Quit();
        }
    }

    public static void toGame(){
        SceneManager.LoadScene("Game");
    }

    public static void exitGame(){
        Application.Quit();
    }
}
