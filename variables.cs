using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_DataType : MonoBehaviour
{
   int myInt = 5;
   float myFloat = 10.5f;
   bool myBool = true;

   public string myString;
    void Start()
    {
       Debug.Log("The value of myInt is : " + myInt);
       Debug.Log("The value of myFloat is : " + myFloat);
       Debug.Log("The value of myBool is : " + myBool);

       Debug.Log("The value of myString is : " + myString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
