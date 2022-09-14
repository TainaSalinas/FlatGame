using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    // Start is called before the first frame update
    
        private float timer = 0;
    public float time = 0;
    private float add = 0.05f;

    public GameObject FirstObject;
    public GameObject SecondObject;


    // Update is called once per frame
    void Update()
    {
        
        
        timer = Time.time;
        if(timer > 1)
        {
            time = time + add;
        }


        
        if (time <= 10)
        {
           FirstObject.SetActive(true);
        }
        else
        {
            FirstObject.SetActive(false);
        }

        if (time > 10)
        {
            SecondObject.SetActive(true);
        }
        else
        {
            SecondObject.SetActive(false);
        }

        if (time >= 20)
        {
            time = 0;
        }
    }
}
