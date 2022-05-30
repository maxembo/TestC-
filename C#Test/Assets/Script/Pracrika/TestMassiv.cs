using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMassiv : MonoBehaviour
{
    void Start()
    {
        int[] array = {1,1,1,1,1};
       
        
        /*for(int i = 0;i<array.Length;i++){
            Debug.Log(array[i]);
        }*/
        foreach(int a in array){
            Debug.Log(a);
        }
        
    }
}
