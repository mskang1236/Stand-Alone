using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedScript : MonoBehaviour
{

    // Main Camera 관련 Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // 침대 인터렉션
    public bool foundDoll;
    public bool canGetBattery = false;
    public ItemScript Inventory;

    // Zoom-in 고정 위치
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {
        // 고정 위치 설정
        zoomPosition = new Vector3(19, 6, 32);
        zoomRotation = Quaternion.Euler(57, 58, -7);

        // Main Camera 불러오기
        cameraPosition = GameObject.Find("Main Camera").GetComponent<Transform>();
        playerViewScript = GameObject.Find("Main Camera").GetComponent<PlayerView>();

        // Inventory 불러오기
        Inventory = GameObject.Find("Inventory").GetComponent<ItemScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        // 클릭 시 줌인
        cameraPosition.position = zoomPosition;
        cameraPosition.rotation = zoomRotation;

        // 침대를 처음 조사할 경우
        if (foundDoll == false)
        {
            Debug.Log("인형이 놓여 있다.");
            foundDoll = true;
        }

        // 드라이버가 없을 경우
        else if (foundDoll == true && Inventory.hasDriver == false)
        {
            Debug.Log("드라이버가 필요하다.");
        }

        // 드라이버가 있을 경우
        else if (foundDoll == true && Inventory.hasDriver == true)
        {
            Debug.Log("인형 안에 건전지가 있다.");
            canGetBattery = true;
        }
    }
}
