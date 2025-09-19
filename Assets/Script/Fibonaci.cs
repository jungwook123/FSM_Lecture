using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Fibonaci : MonoBehaviour
{
    public GameObject square;
    public int count = 3;
    private int tmp = 2;
    private List<Vector3> fibonaci = new List<Vector3>();

    private void Start()
    {
        fibonaci.Add(square.transform.localScale);
        fibonaci.Add(square.transform.localScale);
        Fibo();
    }

    private void Fibo()
    {
        if (tmp < count)
        {
            Vector3 temp = fibonaci[tmp - 1] + fibonaci[tmp - 2];
            fibonaci.Add(temp);
            tmp++;
            print(temp);
            Fibo();
        }
        else
        {
            Vector3[] directions = new Vector3[]
            {
                Vector3.right, Vector3.up, Vector3.left, Vector3.down
            };

            int dirIndex = 0;
            Vector3 currentPos = Vector3.zero;

            for (int i = 0; i < fibonaci.Count; i++)
            {
                GameObject square = GameObject.CreatePrimitive(PrimitiveType.Quad);
                square.transform.localScale = fibonaci[i];
                square.transform.position = currentPos;

                
                Material mat = new Material(Shader.Find("Unlit/Color")); 
                mat.color = Random.ColorHSV();
                square.GetComponent<Renderer>().material = mat;

                if (i < fibonaci.Count - 1)
                {
                    Vector3 moveDir = directions[dirIndex % 4];
                    Vector3 offset = moveDir * (fibonaci[i].x + fibonaci[i + 1].x) * 0.5f;
                    currentPos += offset;
                    dirIndex++;
                }
            }
        }
    }

    
}
