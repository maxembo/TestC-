using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class AlgoritmSortPuz : MonoBehaviour
{
   
    void Start()
    {
       int[] array  = SetArray(100);
       WriteArray(array);

      BubbleSort(array);

       WriteArray(array);
    }

    private int[] SetArray(int length){
        int[] arr = new int[length];
        Random rnd = new Random();
        
        for( int i = 0;i <length;i++){
            arr[i] = rnd.Next(-100,101);
        }
        return arr;
    }
    
    private void WriteArray(int[] arr){
        foreach( int a in arr){
            Debug.Log(a);
        }
    }
    
    private void BubbleSort(int[] arr){
        int temp = 0;
        for(int i = 0;i < arr.Length;i++){
            for(int j = 0;j<arr.Length - i - 1;i++){
                if(arr[j]>arr[j + 1]){
                    temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
             


                }
            }
        }
    }
}
