using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    public float lifeTime=6.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime =lifeTime- Time.deltaTime;
        if(lifeTime<=0.0f)
        {
            Destroy(gameObject);
        }
    }
}
