using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printMessage : MonoBehaviour
{
    private Transform sb;
    // Start is called before the first frame update
    void Start()
    {
        sb = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       if (sb.position.x != 0)
       {
          Debug.Log("Soccer ball: Translation; Frame: " + Time.frameCount + "; Time: " + Time.realtimeSinceStartup + "; Position: " + sb.position);
       }
       if (sb.rotation.x != 0)
       {
          print ("Soccer ball: Rotation; Frame: " + Time.frameCount + "; Time: " + Time.realtimeSinceStartup + "; Position: " + sb.position);
       }
       if (sb.localScale.x != 20)
       {
          print ("Soccer ball: Scaling; Frame: " + Time.frameCount + "; Time: " + Time.realtimeSinceStartup + "; Position: " + sb.position);
       }
    }
}
