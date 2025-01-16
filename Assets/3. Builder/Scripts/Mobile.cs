using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile
{
    private string productName;     // 제품명
    private string companyName;     // 회사명
    private float battery;          // 배터리 양
    private string Resolution;      // 해상도
    private string os;              // 운영체제
                                    // etc...

    public void PrintSpec()
    {
        Debug.Log($"제품명 : {productName}");
        Debug.Log($"회사명 : {companyName}");
        Debug.Log($"배터리 양 : {battery}");
        Debug.Log($"해상도 : {Resolution}");
        Debug.Log($"운영체제 : {os}");
    }
}
