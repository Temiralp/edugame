using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] canta = { "kýlýc", "kalkan", "iksir", "harita" };
        foreach (string esya in canta)
        {
Debug.Log("cantada bu eþya" +esya);
        }

        //can toplama iksir icme
        int[] iksirler = {10,20,30};
        int toplamcan = 0;
        foreach(int can in iksirler)
        {
         Debug.Log(   toplamcan += can);
        }


        string[] dusmanlar = { "zombi", "ejderha" };
        foreach(string dusman in dusmanlar)
        {
            Debug.Log("dusman yenildi + 10 puan" + dusman);
        }

        int[] hasarlar = { 50, 40, 120 };
        foreach(int hasar in hasarlar)
        {
            if (hasar > 100)
            {
                Debug.Log("büyük hasar");
            }
        }

        float[] hizlar = { 1.2f, 0.5f, 2.0f };
        float toplamhiz = 5.0f;
        foreach(float bonus int hizlar){
            toplamhiz += hizlar;

        }
        Debug.Log("yeni hýz" + toplamhiz);


        //secilebilir karakterleri listele
        bool kilitler = { true, false, true };
        int sayac = 1;
        foreach(bool acikmi  in kilitler)
        {
            if (acikmi == true)
            {
                Debug.Log("Karakter" + sayac + "secilebilir");
                sayac++;
            }
        }

        bool[] arkadasdurumlari = { true, false, true };
        int onlinesayisi = 0;
        foreach (bool onlinemi in arkadasdurumlari)
        {
            if (onlinemi == true)
            {
                onlinesayisi++;
            }

            Debug.Log("þu an" + onlinesayisi + "arkadaþlarýn oyunda");
        }
        int[] pingler = { 20, 50, 45, 100 };
        foreach(int ping in pingler)
        {
            if(ping >100)
            {
                Debug.Log("ping çok yüksek oyun yavaþ akýyor");
            }
        }
        
        //ping kontroluintint[int[
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
