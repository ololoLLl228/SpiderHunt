using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlerpSpiderBrownS : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    public float journeyTime = 1.0f;
    public float speed;
    public bool repeatable = true;
    [SerializeField]private GameObject point;

    [SerializeField] private float startTime;
    Vector3 centerPoint;
    private bool centerPointPoint;
    Vector3 startRelCenter;
    private bool startRelCenterPoint;

    Vector3 endRelCenter;
    private bool endRelCenterPoint;
    private bool isGetCenter;

    [SerializeField] private float yCenter;
    // Update is called once per frame
    void Update()
    {

        GetCenter(new Vector3(0, 1, 0));

        if (!repeatable)
        {
            float fracComplete = (Time.time - startTime) / journeyTime*speed;
            transform.position = Vector3.Slerp(startPos.position - centerPoint, endPos.position - centerPoint, Time.time);
            //transform.position += centerPoint;
        }
        if (repeatable)
        {
            float fracComplete = Mathf.PingPong(Time.time - startTime, journeyTime / speed);
            transform.position = Vector3.Slerp(startPos.position - centerPoint, endPos.position - centerPoint, fracComplete * speed);
            //transform.position += centerPoint;
            if (fracComplete >= 1)
            {
                startTime = Time.time;
            }
        }
    }

    public void GetCenter(Vector3 direction)
    {
        centerPoint = (startPos.position + endPos.position) * 0.5f;
        centerPoint -= direction;
        if(!centerPointPoint)
        {
            Instantiate(point, centerPoint, Quaternion.identity);
            centerPointPoint = true;
        }
        startRelCenter = startPos.position - centerPoint;
        if (!startRelCenterPoint)
        {
            GameObject gm2 = Instantiate(point, startRelCenter, Quaternion.identity);
            gm2.transform.localScale += new Vector3(3, 0, 0);
            startRelCenterPoint = true;
        }

        endRelCenter = endPos.position - centerPoint;
        if (!endRelCenterPoint)
        {
            GameObject gm1 = Instantiate(point, endRelCenter, Quaternion.identity);
            gm1.transform.localScale += new Vector3(1, 1, 1);
            endRelCenterPoint = true;
        }
    }
}
