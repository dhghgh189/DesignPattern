using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Factory : MonoBehaviour
{
    // 객체를 생성하고 반환하는 메소드 
    public abstract IProduct GetProduct(Vector3 pos);
}
