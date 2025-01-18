using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    // 이벤트 발생 시 수행할 내용
    void Notify();
}
