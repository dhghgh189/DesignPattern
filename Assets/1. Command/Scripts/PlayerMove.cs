using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public void SetPos(Vector3 targetPos)
    {
        transform.position = targetPos;
    }
}
