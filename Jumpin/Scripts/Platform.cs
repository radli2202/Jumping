using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    [SerializeField] float border, speed;
    Transform tr;
    public Vector2 direct;
    void Start()
    {
        tr = GetComponent<Transform>();
        direct = new Vector2(1, 0);
    }
    
    void Update()
    {
        tr.Translate(direct.normalized * speed);      
        muvet();
    }
       
   void muvet()
    {
       if (tr.position.x >= border) direct = new Vector2(-1, 0);      
       if (tr.position.x <= -border) direct = new Vector2(1, 0);    
    }
     
}
