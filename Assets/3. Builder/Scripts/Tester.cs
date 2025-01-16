using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    MobileBuilder builder;

    void Awake()
    {
        builder = new MobileBuilder();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {     
            Mobile mobile1 = builder.SetProductName("Galaxy Tab S9")
                                .SetCompanyName("Samsung")
                                .SetBattery(8400f)
                                .SetResolution("WQXGA")
                                .SetOS("Android")
                                .Build();

            mobile1.PrintSpec();
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            Mobile mobile2 = builder.SetProductName("iPhone 16 Pro")
                                .SetCompanyName("Apple")
                                .SetBattery(3577f)
                                .SetResolution("2622 x 1206")
                                .SetOS("iOS")
                                .Build();

            mobile2.PrintSpec();
        }
    }
}
