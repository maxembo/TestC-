using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SecondPractika : MonoBehaviour
{
    
    void Start()
    {
        int[] array = SetArray(10);
        WriteArray(array);

        WriteSumOfEvenArray(array);
    }

    private int[] SetArray(int length){
        int[] arr = new int[length];
        Random rand = new Random();

        for(int i = 0;i < length;i++){
            arr[i] = rand.Next(0,101);
        }
        return arr;
    }

    private void WriteArray(int[] arr){
        foreach( int j in arr){
            Debug.Log(j);
        }
    }
    
    private void WriteSumOfEvenArray(int[] arr){
        int sum = 0;
        for(int i = 0; i < arr.Length;i++){
            if(arr[i] % 2 ==0 ){
                sum += arr[i];
            }
        
        }
        Debug.Log(sum);
    }

}
