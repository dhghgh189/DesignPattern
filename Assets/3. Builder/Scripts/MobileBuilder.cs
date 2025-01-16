using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileBuilder : MonoBehaviour
{
    // 생성할 객체에 있는 필드들
    private string productName; 
    private string companyName; 
    private float battery;      
    private string resolution;  
    private string os;          

    // 각 필드를 설정하는 함수들
    // 각 함수는 모두 Builder(자신)을 반환한다.
    public MobileBuilder SetProductName(string productName)
    {
        this.productName = productName;
        return this;
    }

    public MobileBuilder SetCompanyName(string companyName)
    {
        this.companyName = companyName;
        return this;
    }

    public MobileBuilder SetBattery(float battery)
    {
        this.battery = battery;
        return this;
    }

    public MobileBuilder SetResolution(string resolution)
    {
        this.resolution = resolution;
        return this;
    }

    public MobileBuilder SetOS(string os)
    {
        this.os = os;
        return this;
    }

    // 설정된 필드값을 통해 목표 인스턴스를 생성하여 반환
    public Mobile Build()
    {
        Mobile mobile = new Mobile(productName, companyName, battery, resolution, os);
        return mobile;
    }
}
