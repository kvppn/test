using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class SaleSlot : MonoBehaviour, IPointerClickHandler
{
    public Item slotItem;//�����е���Ʒ
    public Image slotImage;//���ӵ�ͼƬ
    public Text slotNum;//������Ʒ������
    public Text Saleinfo;
    public MoneyController money;
    static SaleSlot instance;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Saleinfo = GameObject.FindGameObjectWithTag("saleInfo").GetComponent<Text>();
        money = GameObject.FindGameObjectWithTag("money").GetComponent<MoneyController>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        // ������
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("���缫");
            Saleinfo.text = slotItem.itemInfo;
            //��ť���
            saleClothes.GetMoneyNum(slotItem.money);
        }
    }
   
}