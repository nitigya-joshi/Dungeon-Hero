using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothCameraFollow : MonoBehaviour
{
    #region Variables
    
        private Vector3 _offset;
        [SerializeField] private Transform target;
        [SerializeField] private Transform target2;
        [SerializeField] private float smoothTime;
        // [SerializeField] GameObject isComplete;
        private Vector3 _currentVelocity = Vector3.zero;
    #endregion
        

        //bool lvl1 = isComplete.GetComponent<EnemyScript>().lvl1Completed;
    #region Unity callbacks
    
        private void Awake() => _offset = transform.position - target.position;

        private void LateUpdate()
        {
            Vector3 targetPosition = target.position + _offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothTime);
        }
        
    #endregion
    // void targetChange(Transform player){
    //     target=player;
    // }
}
