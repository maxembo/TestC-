using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPractika : MonoBehaviour
{
    void Start()
    {
        SumOfEvenNum(7,21);
        
    }

     private void SumOfEvenNum(int firstNum,int secondNum){
        int sum = 0;
        for(; firstNum <= secondNum;firstNum++){
            if(firstNum % 2 == 0){
                sum += firstNum;
            }
        
        }
        Debug.Log(sum);
    }
}
