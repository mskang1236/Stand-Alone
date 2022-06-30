using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDollBattery : MonoBehaviour
{
    // Main Camera ���� Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // Inventory and Blanket
    public BedScript GetBedScript;
    public ItemScript Inventory;

    // bool
    public bool bedClicked = false;
    public bool getBattery = false;

    // Start is called before the first frame update
    void Start()
    {
        // BedScript �ҷ�����
        GetBedScript = GameObject.Find("Blanket").GetComponent<BedScript>();

        // Inventory �ҷ�����
        Inventory = GameObject.Find("Inventory").GetComponent<ItemScript>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        if (GetBedScript.canGetBattery == true)
        {
            Debug.Log("�������� ȹ���ߴ�.");
            getBattery = true;
        }
    }
}
