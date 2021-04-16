using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public Text sushi;
    public static int numSushi;

    // Start is called before the first frame update
    void Start()
    {
        sushi.text = "Sushi:" ;
        numSushi = 0;
    }

    // Update is called once per frame
    void Update()
    {
        sushi.text = "Sushi: "+numSushi;
    }
}
