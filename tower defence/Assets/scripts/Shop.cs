
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint standardTurret;
    public TurretBlueprint anotherTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;


    }

   



    public void SelectStandardTurret ()
    {
        print("Standard turret selected");
        buildManager.SelectTurretToBuild(standardTurret);
       

    }

    public void SelectAnotherTurret ()
    {
        print("Another turret selected");
        buildManager.SelectTurretToBuild(anotherTurret);

    }




}
