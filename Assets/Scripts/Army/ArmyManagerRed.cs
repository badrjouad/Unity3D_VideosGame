using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using UnityEngine.AI;

public class ArmyManagerRed : ArmyManager
{
	public override void ArmyElementHasBeenKilled(GameObject go)
	{
		base.ArmyElementHasBeenKilled(go);
		if (m_ArmyElements.Count == 0)
		{
			GUIUtility.systemCopyBuffer = "0\t" +((int)Timer.Value).ToString()+"\t0\t0\t0";
		}
	}
	public void GreenArmyIsDead(string deadArmyTag)
    {
        int nDrones = 0, nTurrets = 0, health = 0;
        ComputeStatistics(ref nDrones, ref nTurrets, ref health);
		GUIUtility.systemCopyBuffer = "1\t" + ((int)Timer.Value).ToString() + "\t"+nDrones.ToString()+"\t"+nTurrets.ToString()+"\t"+health.ToString();
		
		RefreshHudDisplay(); //pour une derni�re mise � jour en cas de victoire
	}
	/*public  ChooseTarget target (GameObject go)
	{
		target.Value = m_ArmyElement.ArmyManager.GetRandomEnemy<Turret>(transform.position,minRadius.Value,maxRadius.Value)?.transform;
		while(turret.nTurrets !=0)
		{
			if(turret.health == 0)
			{
				target.Value = m_ArmyElement.ArmyManager.GetRandomEnemy<Turret>(transform.position,minRadius.Value,maxRadius.Value)?.transform;
			}
		}
		return target.Value;
	}*/
}