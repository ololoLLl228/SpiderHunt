using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentS : MonoBehaviour
{
    [SerializeField] private Transform player;
    private float step = 1f;
    public Color color;
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        renderer = GetComponent<Renderer>();
        color = renderer.materials[0].color;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < player.position.z + 2f)
        {
            StartCoroutine("Fade");
        }
    }
    IEnumerator Fade()
    {
        if(color.a > 0)
        {
            while(color.a > 0)
            {
                color.a -= step / 100;
                renderer.material.color = color;
                yield return new WaitForFixedUpdate();
            }
        }
    }
}
