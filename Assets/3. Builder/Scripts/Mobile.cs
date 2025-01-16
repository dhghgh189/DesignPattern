using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile
{
    private string productName;     // 제품명
    private string companyName;     // 회사명
    private float battery;          // 배터리 양
    private string resolution;      // 해상도
    private string os;              // 운영체제
                                    // etc...

    public Mobile(string productName, string companyName, float battery, string resolution, string os)
    {
        this.productName = productName;
        this.companyName = companyName;
        this.battery = battery;
        this.resolution = resolution;
        this.os = os;
    }

    public void PrintSpec()
    {
        Debug.Log($"제품명 : {productName}");
        Debug.Log($"회사명 : {companyName}");
        Debug.Log($"배터리 양 : {battery}");
        Debug.Log($"해상도 : {resolution}");
        Debug.Log($"운영체제 : {os}");
    }
}
