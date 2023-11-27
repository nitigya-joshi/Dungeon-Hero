using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float turnSpeed;
    void Start()
    {
                // Cursor.visible=false;
                // Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        bool isLeftButtonDown = Input.GetMouseButtonDown(0);
        // if(isLeftButtonDown){
            float rot=Input.GetAxis("Mouse X");
            rot*=turnSpeed;
            float rotationAmount = transform.eulerAngles.y+rot;
            transform.eulerAngles = new Vector3(0, rotationAmount, 0);
            // Debug.Log(rot);
            // transform.Rotate(Vector3.up, rotationAmount);
            // player.transform.eulerAngles=new Vector3(0,player.transform.eulerAngles.y+y,0);
        // }
        // Vector3 mousePosition=Input.mousePosition;
        // mousePosition=Camera.main.ScreenToWorldPoint(mousePosition);
        // Vector2 direction=new Vector2(mousePosition.x-transform.position.x,mousePosition.y-transform.position.y);
        // transform.up=direction;
    }
}
