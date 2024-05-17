using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Platform : MonoBehaviour
{

    [SerializeField] private float fallSpeed;


    private void Awake(){

    }

    private void Start(){

    }
    private void Update(){

        HandleDestroy();

        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

    }
    private void HandleDestroy(){
        int lowestPlatformPos = -5;
        if (transform.position.y < lowestPlatformPos)
        {
            Destroy(gameObject);
        }
    }
}
