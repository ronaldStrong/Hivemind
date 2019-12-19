using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int gameXMax = Screen.width;
        int gameYMax = Screen.height;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class DisjointSet{
    public DisjointSet(int size){
        s = new int[size];
        for(int i = 0; i < size; ++i){
            s[i] = -1;
        }
    }

    public void union(int el1, int el2){
        int root1 = find(el1);
        int root2 = find(el2);
        if(root1 == root2){
            return;
        }

        if(s[root2] < s[root1]){
            s[root1] = root2;
        }
        else{
            if(s[root1] == s[root2]){
                --s[root1];
            }
            s[root2] = root1;
        }
    }

    public int find(int x){
        if(s[x] < 0){
            return x;
        }
        else{
            s[x] = find(s[x]);
            return s[x];
        }
    }

    private int[] s;
}