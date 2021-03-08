using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follower : MonoBehaviour
{
    Camera mainCam;
    Vector3 smoothPos;
    public float smoothRate;
    public Transform followTransform;
  
    float yMin;
    float camSize;
    float yMax;
    float xMax;
    float xMin;
    float camRatio;
    float camY;
    float camX;
    public BoxCollider2D worldBound;
    void Start()
    {
        xMin = worldBound.bounds.min.x;
        xMax = worldBound.bounds.max.x;
        yMin = worldBound.bounds.min.y;
        yMax = worldBound.bounds.max.y;
        mainCam = gameObject.GetComponent<Camera>();
        camSize = mainCam.orthographicSize;
        camRatio = (xMax + camSize) / 8.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
      
            camY = Mathf.Clamp(followTransform.position.y, yMin + camSize, yMax - camSize);
            camX = Mathf.Clamp(followTransform.position.x, xMin + camRatio, xMax - camRatio);
        
        smoothPos = Vector3.Lerp(gameObject.transform.position, new Vector3(camX, camY, gameObject.transform.position.z), smoothRate);
        gameObject.transform.position = smoothPos;
    }
}
