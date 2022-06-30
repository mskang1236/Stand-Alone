using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    // 아이템 소유 여부 확인
    public bool hasChair = false;
    public bool hasDriver = false;
    public bool hasClockBattery = false;
    public bool hasDollBattery = false;
    public bool hasAllBatteries = false;

    // 아이템을 획득할 수 있는 곳
    public GetChair GetChairScript;
    public GetClockBattery GetClockBatteryScript;
    public GetDollBattery GetDollBatteryScript;
    public GetScrewDriver GetScrewDriverScript;
    //public GetDollBattery GetDollBatteryScript;

    // Start is called before the first frame update
    void Start()
    {
        GetChairScript = GameObject.Find("Chair").GetComponent<GetChair>();
        GetClockBatteryScript = GameObject.Find("clock").GetComponent<GetClockBattery>();
        GetDollBatteryScript = GameObject.Find("rabbit doll").GetComponent<GetDollBattery>();
        GetScrewDriverScript = GameObject.Find("screwdriver").GetComponent<GetScrewDriver>();
    }

    // Update is called once per frame
    void Update()
    {
        // 건전지 확인
        if (GetClockBatteryScript.getBattery == true)
        {
            hasClockBattery = true;
        }

        if (GetDollBatteryScript.getBattery == true)
        {
            hasDollBattery = true;
        }

        // 건전지 개수 확인
        if (hasClockBattery == true && hasDollBattery == true)
        {
            hasAllBatteries = true;
        }

        // 드라이버 확인
        if (GetScrewDriverScript.getDriver == true)
        {
            hasDriver = true;
        }
    }
}
