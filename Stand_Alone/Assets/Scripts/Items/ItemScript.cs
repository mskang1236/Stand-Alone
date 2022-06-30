using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    // ������ ���� ���� Ȯ��
    public bool hasChair = false;
    public bool hasDriver = false;
    public bool hasClockBattery = false;
    public bool hasDollBattery = false;
    public bool hasAllBatteries = false;

    // �������� ȹ���� �� �ִ� ��
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
        // ������ Ȯ��
        if (GetClockBatteryScript.getBattery == true)
        {
            hasClockBattery = true;
        }

        if (GetDollBatteryScript.getBattery == true)
        {
            hasDollBattery = true;
        }

        // ������ ���� Ȯ��
        if (hasClockBattery == true && hasDollBattery == true)
        {
            hasAllBatteries = true;
        }

        // ����̹� Ȯ��
        if (GetScrewDriverScript.getDriver == true)
        {
            hasDriver = true;
        }
    }
}
