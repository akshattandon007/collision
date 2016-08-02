using UnityEngine;

public class BallMove : MonoBehaviour
{
    public int ballVelocity;
    public GameObject brick;
    bool isMoving;
    
    void Start() {
        isMoving = true;
        brick.GetComponent<Collider>();
        gameObject.GetComponent<Collider>();
    }
    void FixedUpdate()
    {   
       
    }
    void Update() {
       
    }
    void collision() {
        if (isMoving)
            transform.Translate(Vector3.up * Time.deltaTime * ballVelocity);
            Vector3 fwd = gameObject.transform.TransformVector(0,gameObject.transform.position.y,0);
            Vector3 dist = fwd + brick.transform.TransformVector(0,gameObject.transform.position.y,0);
            Debug.Log(dist.magnitude);
           if (dist.magnitude ==0){
                isMoving = false;
                ballVelocity = 0;
           }
          collision();
       }
           
    
    
    }
