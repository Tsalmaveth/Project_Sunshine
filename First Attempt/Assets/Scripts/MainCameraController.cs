using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 offset;
    [SerializeField] float followDistacnce;
    [SerializeField] Quaternion followRotation;

    private void Update()
    {
        Vector3 pos = Vector3.Lerp(transform.position, player.position + offset + -transform.forward * followDistacnce, moveSpeed * Time.deltaTime);
        transform.position = pos;

        transform.rotation = followRotation;
      
    }


}
