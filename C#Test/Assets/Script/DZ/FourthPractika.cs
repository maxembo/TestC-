using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthPractika : MonoBehaviour
{
    
    void Start()
    {
        int[] array = {-2,4,5,6,2,-4,9,10,-6, 0,7};
        SortArray(array);

        WriteArray(array);
    }
    private int[] SortArray(int[] arr) { 
        for(int i = 0; i < arr.Length;i++){
           int min = i;
            for( int j = i + 1; j < arr.Length -1;j++){
                 if(arr[min] > arr[j])
                     min = j;
            }
             int temp = arr[i];
             arr[i] = arr[min];
             arr[min] = temp;
        }
        return arr;
    }
   private void WriteArray(int[] arr)
    {
        foreach (int a in arr)
            Debug.Log(a);
    }
}