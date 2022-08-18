using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dortislem : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEngine.UI.Text sayi1, sayi2, islem, cevap, dy;
    int ilksayi, ikincisayi, isaret;
    int islemsonuc;

    void Start()
    {
        Yenisoru();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void kontrol()
    {
        if (int.Parse(cevap.text) == islemsonuc)
        {
            dy.text = "doðru";

        }
        else
        {
            dy.text = "yanlýþ";
            
        }
    }

    public void Yenisoru()
    {
        cevap.text = "";
        dy.text = "";
        ilksayi = Random.Range(1, 10);
        ikincisayi = Random.Range(1, 10);
        isaret = Random.Range(1, 4);
        switch (isaret)
        {
            case 1:
                islem.text = "+";
                islemsonuc = ilksayi + ikincisayi;
                break;
            case 2:
                islem.text = "-";
                islemsonuc = ilksayi - ikincisayi;
                break;
            case 3:
                islem.text = "/";
                islemsonuc = ilksayi / ikincisayi;
                break;
            case 4:
                islem.text = "*";
                islemsonuc = ilksayi * ikincisayi;
                break;
        }
        sayi1.text = ilksayi + "";
        sayi2.text = ikincisayi + "";

    }


}
