using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowS : MonoBehaviour
{
    [SerializeField]
    private float xMax;
    [SerializeField]
    private float yMax;
    [SerializeField]
    private float xMin;
    [SerializeField]
    private float yMin;



    private void Start()
    {

        target = GameObject.Find("Player").transform;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, xMin, xMax), Mathf.Clamp(target.position.y, yMin, yMax),transform.position.z);
    }

    //co sledzimy
    public Transform target;
/*
      Vector3 velocity = Vector3.zero;

      public float smoothTime = .15f;

      //czas sledzenia celu

      private void Start()
      {

          target = GameObject.Find("Player").transform;
      }

      void fixedUpdate()
      {
          //pozycja celu
          Vector3 targetPos = target.position;

          targetPos.z = transform.position.z;

          transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);

     */
}

