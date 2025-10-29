using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

     public  Transform  Target ;
      public float CameraSpeed ; 

    public float minX , maxX ;
    public float minY , maxY ; 
   
    void Start()
    {
        
    }

void FixedUpdate()
{
    if (Target != null)
    {
       
        Vector2 currentPosition = transform.position;
        Vector2 targetPosition = Target.position;

        
        Vector2 newPosition = Vector2.Lerp(currentPosition, targetPosition, CameraSpeed * Time.fixedDeltaTime);

       float clampedX = Mathf.Clamp(newPosition.x, minX, maxX);
        float clampedY = Mathf.Clamp(newPosition.y, minY, maxY);

        
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
       
    }
}

    
 void Update()
    {
       
    }


    }
 
   
