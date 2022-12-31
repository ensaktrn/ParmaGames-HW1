using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int counterValue = 0;
    public static Counter Instance;
    public TMP_Text tmpText;
    

   
    public void Awake()
    {
        Instance = this;
    }
    public void IncreaseCounter(){
        counterValue++;
        tmpText.text = "Score: "+counterValue.ToString();

    }
}
