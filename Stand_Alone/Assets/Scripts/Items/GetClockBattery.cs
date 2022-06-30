using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetClockBattery : MonoBehaviour
{

    // Main Camera 관련 Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // Chair
    public GetChair GetChairScript;

    // bool
    public bool chairClicked = false;
    public bool getBattery = false;

    // Zoom-in 고정 위치
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {
        // 클릭 시 줌인되는 고정 위치 설정
        zoomPosition = new Vector3(12, 8, -20);
        zoomRotation = Quaternion.Euler(0, 180, 0);

        // Main Camera 불러오기
        cameraPosition = GameObject.Find("Main Camera").GetComponent<Transform>();
        playerViewScript = GameObject.Find("Main Camera").GetComponent<PlayerView>();

        // GetChair 불러오기
        GetChairScript = GameObject.Find("Chair").GetComponent<GetChair>();
    }

    // Update is called once per frame
    void Update()
    {
        if (chairClicked == true)
        {
            OnMouseDown();
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("시계 안에 건전지가 있다.");
        getBattery = true;
    }
}
