using System;
using System.Collections.Generic;
using System.Collections;
namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] queries = new int[3][];
            queries[0] = new int[]{1, 5, 3};
            queries[1] = new int[]{4, 8, 7};
            queries[2] = new int[]{6, 9, 2};
            arrayManipulation( 10, queries);
        }

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries) {
        long[][] arr = new long[queries.Length * 2][];
        for(int j=0; j<arr.Length; j++)
        {
           arr[j] = new long[]{-1, 0};
        }
        long max = 0;
        for(int i=0; i<queries.Length; i++){
            int val = queries[i][2];
            int l=queries[i][0]-1;
            int u=queries[i][1]-1;
            for(int k=0; k<arr.Length; k++){
                // evaluate the existence of lower boundary:
                if(arr[k][0] == l || arr[k][0]== u){
                    arr[k][1] += val;
                }
                else if (arr[k][0]==-1){ 
                    arr[k][0]= l;
                }

            }

        }
        Console.WriteLine(max);
        return max;
        // long[] arr = new long[n];
        // long max = 0;
        // Array.Fill(arr, 0);
        // for(int i=0; i<queries.Length; i++){
        //     for(int k=queries[i][0]; k<=queries[i][1]; k++){
        //         arr[k]+=queries[i][2];
        //         if (arr[k]>max){
        //             max = arr[k];
        //         }
        //     }
        // }
        // Console.WriteLine(max);
        // return max;
    }
    }
}
