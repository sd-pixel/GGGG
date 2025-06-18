using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zhuan : MonoBehaviour
{
    public Button ChouJiangBtn;
    private bool blose = false;
    private Vector3 currentRotation;
    private float time;
    private int nums = 0;
    private List<int> list = new List<int>();
    public Transform weizhi;
    // Start is called before the first frame update
    void Start()
    {
        //��ȡŷ����
        currentRotation = GetComponent<RectTransform>().eulerAngles;
        //����齱��ť��ʼ�齱
        ChouJiangBtn.onClick.AddListener(() =>
        {
            time = Random.Range(1, 3);
            blose = true;
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (blose == true)
        {
            //��ȡŷ����
            currentRotation = GetComponent<RectTransform>().eulerAngles;
            //���ýǶ�
            Vector3 newRoation = currentRotation + new Vector3(0, 0, 60) * Time.deltaTime;
            GetComponent<RectTransform>().eulerAngles = newRoation;

            //ʱ��
            time -= Time.deltaTime;
            if (time <= 0)
            {
                blose = false;
                float angle = newRoation.z % 360;
                if (angle <= 60)
                {
                    nums = 1;
                    list.Add(nums);
                    Refas();
                }
                else if (angle <= 120)
                {
                    nums = 2;
                    list.Add(nums);
                    Refas();
                }
                else if (angle <= 180)
                {
                    nums = 3;
                    list.Add(nums);
                    Refas();

                }
                else if (angle <= 240)
                {
                    nums = 4;
                    list.Add(nums);
                    Refas();
                }
                else if (angle <= 300)
                {
                    nums = 5;
                    list.Add(nums);
                    Refas();
                }
                else if (angle <= 360)
                {
                    nums = 6;
                    list.Add(nums);
                    Refas();

                }
            }
            void Refas()
            {
                StartCoroutine(WaitAndSetEulerAngle());
            }
        }
    }

    IEnumerator WaitAndSetEulerAngle()
    {
        yield return new WaitForSeconds(2f);

    }
    private Dictionary<int, GameObject> dic = new Dictionary<int, GameObject>();

    public void SetBtn()
    {
        for(int i = 0; i < list.Count; i++)
        {
            //�ҵ�Ԥ����
            GameObject game = Resources.Load<GameObject>("Item");
            //�ҵ�λ�ð�Ԥ�������
            GameObject games = Instantiate(game, weizhi);
            Debug.Log(list[i]);
            games.GetComponent<Image>().sprite = Resources.Load<Sprite>("Zhuan/" + list[i]);

        }
        for(int i = 0; i < list.Count; i++)
        {
            list.RemoveAt(i);
        }
    }
}
