using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update

    public float lifeTime;
    void Start()
    {
        StartCoroutine(FadeDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FadeDelay()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}