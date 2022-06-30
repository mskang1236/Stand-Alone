using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureScript : MonoBehaviour
{
    // Main Camera ���� Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // Zoom-in ���� ��ġ
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {
        // ���� ��ġ ����
        zoomPosition = new Vector3(2, 6, 27);
        zoomRotation = Quaternion.Euler(-19, 0, 0);

        // Main Camera �ҷ�����
        cameraPosition = GameObject.Find("Main Camera").GetComponent<Transform>();
        playerViewScript = GameObject.Find("Main Camera").GetComponent<PlayerView>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        // Ŭ�� �� ����
        cameraPosition.position = zoomPosition;
        cameraPosition.rotation = zoomRotation;
    }
}
