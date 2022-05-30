using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPractika : MonoBehaviour
{
    
    void Start()
    {
        int[] array = {81, 22, 13, 34, 10, 34, 15, 26, 71, 68};
        SearchIndexInArray(array,43);
    }
    private void SearchIndexInArray(int[] arr, int number){
         int result = 0;
        for(int i = 0;i < arr.Length;i++){
            if(number == arr[i]){
              result = i;
              break;
            } else 
         result = -1;
        }
      Debug.Log($"Индекс первого вхождения числа {number} в массив:{result}");
    }
    
}
