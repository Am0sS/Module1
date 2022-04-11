using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObjects : MonoBehaviour
{

    [SerializeField] GameObject prefabs;
    [SerializeField] GameObject baseClock;
    [SerializeField] GameObject clockWithTexture;
    [SerializeField] GameObject baseClockIndicator;
    [SerializeField] GameObject prefabIndicator;
    [SerializeField] GameObject clockWithTextureIndicator;
    [SerializeField] Material Material1, Material2;

    public bool BCVisible;
    public bool TClockVisible;
    public bool prefabVisible;

    // Start is called before the first frame update
    void Start()
    {
        prefabs.SetActive(false);
        baseClock.SetActive(false);
        clockWithTexture.SetActive(false);
    }


    // SHOW / HIDE PREFABS
    void ShowPrefabs()
    {
    prefabVisible = true;
    prefabs.SetActive(true);
    prefabIndicator.GetComponent<MeshRenderer>().material = Material2;
    }
    void HidePrefabs()
    {
    prefabVisible = false;
    prefabs.SetActive(false);
    prefabIndicator.GetComponent<MeshRenderer>().material = Material1;
    }
    // SHOW / HIDE BASEC CLOCK
    void ShowBaseClock()
    {
    BCVisible = true;
    baseClock.SetActive(true);
    baseClockIndicator.GetComponent<MeshRenderer>().material = Material2;
    }
    void HideBaseClock()
    {
    BCVisible = false;
    baseClock.SetActive(false);
    baseClockIndicator.GetComponent<MeshRenderer>().material = Material1;
    }
    // SHOW/HIDE CLOCK WITH TEXTURE
    void ShowTextureClock()
    {
    TClockVisible = true;
    clockWithTexture.SetActive(true);
    clockWithTextureIndicator.GetComponent<MeshRenderer>().material = Material2;
    }
    void HideTextureClock()
    {
    TClockVisible = false;
    clockWithTexture.SetActive(false);
    clockWithTextureIndicator.GetComponent<MeshRenderer>().material = Material1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && TClockVisible == false && BCVisible == false)
        {
            ShowPrefabs();
        }
         if (Input.GetKeyDown(KeyCode.O))
        {
            HidePrefabs();
        }
        if (Input.GetKeyDown(KeyCode.H) && prefabVisible == false && TClockVisible == false)
        {
            ShowBaseClock();
        }
         if (Input.GetKeyDown(KeyCode.G))
        {
            HideBaseClock();
        }
          if (Input.GetKeyDown(KeyCode.T) && prefabVisible == false && BCVisible == false)
        {
            ShowTextureClock();
        }
         if (Input.GetKeyDown(KeyCode.R))
        {
            HideTextureClock();
        }
        
    }
}
