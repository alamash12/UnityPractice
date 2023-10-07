using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Collider2D coll;
    WaitForFixedUpdate waitf = new WaitForFixedUpdate();

    private float cooltime = 0.3f;

    private void Awake()
    {
        coll = GetComponent<Collider2D>();
    }

    public void Enable()
    {
        StartCoroutine(Cooltime());
    }

    IEnumerator Cooltime()
    {
        float time = 0;
        gameObject.layer = LayerMask.NameToLayer("DownPlatform");
        coll.isTrigger = true;
        while(time < cooltime)
        {
            time += Time.deltaTime;
            yield return waitf;
        }
        gameObject.layer = LayerMask.NameToLayer("Platform");
        coll.isTrigger = false;
    }
}
