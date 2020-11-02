using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
public class Ads : MonoBehaviour
{
    private InterstitialAd reklamObjesi;

    void Start()
    {
        MobileAds.Initialize(reklamDurumu => { });
    }
    public void reklam()
    {
        if (reklamObjesi != null)
            reklamObjesi.Destroy();
        reklamObjesi = new InterstitialAd("ca-app-pub-5801080710135130/3307749104");
        AdRequest reklamIstegi = new AdRequest.Builder().Build();
        reklamObjesi.LoadAd(reklamIstegi);
        StartCoroutine(ReklamiGoster());

    }
    IEnumerator ReklamiGoster()
    {
        while (!reklamObjesi.IsLoaded())
            yield return null;

        reklamObjesi.Show();
    }
    void OnDestroy()
    {
        if (reklamObjesi != null)
            reklamObjesi.Destroy();
    }
}