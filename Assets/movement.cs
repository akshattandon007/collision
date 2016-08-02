using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    public bool updateOn = true;
    public int vel;
	// Use this for initialization
    void Start(){
        StartCoroutine(MyUpdate());
 }

    IEnumerator MyUpdate()
    {
        float timer = 0;
       double timing = 0.64f / vel;
        double time = 5f;
        while (timer < time)
        {
            transform.Translate(Vector3.up * Time.deltaTime * vel);
            timer += Time.deltaTime;
            if (timer == timing)
                vel = 0;
            yield return null;
        }
        // Here do anything that needs be done after 5s
    }
}
