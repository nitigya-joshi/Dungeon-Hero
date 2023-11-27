using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform rightHand;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=rightHand.position;
    }
}
