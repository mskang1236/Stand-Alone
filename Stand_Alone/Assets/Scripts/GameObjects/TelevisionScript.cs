using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelevisionScript : MonoBehaviour
{

    // Main Camera ���� Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // �ڷ����� ���ͷ���
    public bool televisionOn;
    public bool watchedCampaign;

    // Zoom-in ���� ��ġ
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {
        // Ŭ�� �� ���εǴ� ���� ��ġ ����
        zoomPosition = new Vector3(12, 8, -20);
        zoomRotation = Quaternion.Euler(0, 180, 0);

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

        // �ڷ������� ó�� ������ ���
        if (televisionOn == false)
        {
            Debug.Log("�ڷ������� Ų��");
            televisionOn = true;
        }

        // �ڷ������� ų ���
        else if (televisionOn == true && watchedCampaign == false)
        {
            Debug.Log("�Ƶ��д� �Ű� ķ���� ���� �����̴�.");
            watchedCampaign = true;
        }

        // ķ���� ���� ���� ��û ��
        else if (televisionOn == true && watchedCampaign == true)
        {
            Debug.Log("���ͱ��� ��۵ǰ� �ִ�.");
        }
    }
}
