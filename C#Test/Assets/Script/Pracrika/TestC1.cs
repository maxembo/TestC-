using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestC1 : MonoBehaviour
{
    
    void Start()
    {
     
    /*for(int i =7;i>=2;i--){
         Debug.Log(i);
     }
     */
     /*
     int j = 0;
     
     while(j++<5){
         Debug.Log(j);
     }
     */
     double n = 8;

     if(n>0){
         for(int i = 2; i<n;i++){
             if(n % i == 0){
                Debug.Log($"Число {n} является простым");
             } 
         } 
     }
  }
}
