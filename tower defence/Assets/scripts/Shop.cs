
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;


    }

   



    public void PurchaseStandardTurret ()
    {
        print("Standard turret bought");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
       

    }

    public void PurchaseAnotherTurret ()
    {
        print("Another turret bought");
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);

    }




}
