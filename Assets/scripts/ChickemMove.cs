using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickemMove : MonoBehaviour
{
     public float speed;
    private float waitTime;           //время отдыха между передвижениями
    public float startWaitTime;
    private float angle;
    bool wait = false;
    Vector3 moveTarget;

    private float vZ;
    private Vector3 MouseOffSet;
    private float MouseZCoord;
    Animator anim;
   public GameObject chicken;

    void OnMouseDown()
    {
        MouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        MouseOffSet = gameObject.transform.position - GetMousePosition();

        anim.SetTrigger("WaitTrigger");


    }
    void OnMouseUp()
    {
        anim.SetTrigger("RunAgainTrigger");

    }
    private Vector3 GetMousePosition()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = MouseZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position=GetMousePosition() + MouseOffSet; 
    }
    void Start()
    {
        waitTime = startWaitTime;
        vZ = Random.Range(-10f, 10f);
        transform.eulerAngles = new Vector3(0, 0, 0);
        transform.position = new Vector3(0, 0, 0);      //стартуем в центре карты
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if(wait)
                {
            waitTime -= Time.deltaTime;
            if (waitTime < 0)
            {
                wait = false;
                moveTarget = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            }

            //Vector2 pos = new Vector2(transform.position.x, transform.position.z);  
            //Vector2 tar = new Vector2(moveTarget.x, moveTarget.z);  

            //angle = Vector2.Angle(pos, tar);
            // Debug.Log(angle);
            //transform.Rotate(0f, angle, 0f, Space.Self);

            //if (transform.position.z > moveTarget.z) {
            //  transform.Rotate(0f, 180, 0f, Space.Self);
            //
            
                Vector3 relativePos = moveTarget - transform.position;

                // the second argument, upwards, defaults to Vector3.up
                Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
                transform.rotation = rotation;
            }
            
        else
                {

            transform.position = Vector3.MoveTowards(transform.position, moveTarget, speed * Time.deltaTime);

            if(Vector3.Distance(transform.position, moveTarget) < 0.5f)
                        {
                wait = true;
                waitTime = startWaitTime;
                        }
                }
    }
}
