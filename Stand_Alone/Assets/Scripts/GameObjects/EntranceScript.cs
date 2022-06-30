using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceScript : MonoBehaviour
{
    // Main Camera 관련 Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // 아이템 보유 현황
    public ItemScript Inventory;

    // Zoom-in 고정 위치
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // 게임 종료 여부
    public bool gameClear = false;

    // Start is called before the first frame update
    void Start()
    {

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
        // 클릭 시 줌인되는 고정 위치 설정
        if (Inventory.hasChair == false) { zoomPosition = new Vector3(-33, 6, 55); }
        else { zoomPosition = new Vector3(-33, 20, 55); }
        zoomRotation = Quaternion.Euler(0, 0, 0);

        // 클릭 시 줌인
        cameraPosition.rotation = zoomRotation;
        cameraPosition.position = zoomPosition;

        // 의자가 없을 경우
        if (Inventory.hasChair == false)
        {
            Debug.Log("키가 닿지 않는다.");
        }

        // 의자는 있지만, 드라이버와 건전지 모두 없을 경우
        else if (Inventory.hasDriver == false && (Inventory.hasClockBattery == false && Inventory.hasDollBattery == false))
        {
            Debug.Log("문이 열리지 않는다.");
        }

        // 드라이버가 없지만, 건전지가 있을 경우
        else if (Inventory.hasDriver == false && Inventory.hasAllBatteries == true)
        {
            Debug.Log("문을 열 수 있는 도구가 필요하다.");
        }

        // 드라이버는 있지만 건전지가 없을 경우
        else if (Inventory.hasDriver == true && Inventory.hasClockBattery == false && Inventory.hasDollBattery == false)
        {
            Debug.Log("도어락에 배터리가 없다.");
        }

        // 드라이버가 있지만, 건전지 개수가 부족할 경우
        else if (Inventory.hasDriver == true && (Inventory.hasClockBattery == true || Inventory.hasDollBattery == true) && Inventory.hasAllBatteries == false)
        {
            Debug.Log("건전지가 부족하다.");
        }

        // 드라이버도 있고, 모든 건전지를 갖고 있을 경우
        else if (Inventory.hasDriver == true && Inventory.hasAllBatteries == true)
        {
            Debug.Log("게임 종료");
            gameClear = true;
        }
    }
}
