using System.collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private const int Posy =-8;
    private const int speed = 25;
    private const int Horizontallimity = 15;

    public Transform BulletPrefab;
     
     void Start()
     {
        instance(BulletPrefab,Transform.position,Quaternion.identity);
     }
     Void Update()
     {
        
     }
}