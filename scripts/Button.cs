using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public bool isHit=false;
    public static float x;
    public Counter counter;
   
    void Update()
    {
        x= Mathf.Abs(Cube.Instance.transform.rotation.eulerAngles.x);
    }

    public void OnButtonClick()
    {
        // 12 derece hata payı bıraktım.
        if( (x<= 6 || (x>=84 && x<=106) || (x>=174 && x<=186) || (x>=264 && x<=276) || (x>=354 && x<=360)) && !isHit ){
            counter.IncreaseCounter();
            isHit= true;
            StartCoroutine(ResetHit()); 
        }
    }

    public IEnumerator ResetHit(){
        yield return new WaitForSeconds(0.5f);
        isHit=false;
    }
}