using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderManager : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider _col;
    void Start()
    {
        _col=gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        bool attack=Input.GetKey("q");
        if(attack){
            _col.enabled=true;
        }
        else{
            _col.enabled=false;
        }
    }
}
