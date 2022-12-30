using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UISwapHandler : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    private Transform player;
    private float speed = 1f;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

        Vector2 delta = eventData.delta;
        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        {
            Vector3 position = player.position;
            position.x += (speed*Time.deltaTime) * delta.x;
            player.position = position;
        }
        else
        {
            if (delta.y > 0)
            {
                Debug.Log("up");
            }
            else
            {
                Debug.Log("Down");
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }
}
