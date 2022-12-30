using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathS : MonoBehaviour
{
    private float dyingTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Dying");
    }

    IEnumerator Dying()
    {
        yield return new WaitForSeconds(dyingTime);
        Destroy(gameObject);
    }

}
