using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using UnityEngine.AI;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class ArmyManagerRed : ArmyManager
{
	public SharedTransform target;
	public SharedTransform cible;
	public SharedFloat minRadius;
	public SharedFloat maxRadius;
	IArmyElement m_ArmyElement;
	/*
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

	public void Update(){
		if(target.Value != null)
		{	
			target.Value = m_ArmyElement.ArmyManager.GetRandomEnemy<Turret>(transform.position,minRadius.Value,maxRadius.Value)?.transform;
			cible=target.Value;
		}

	}
	*/
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

	public void Update(){
		if(target.Value != null)
		{	
			target.Value = m_ArmyElement.ArmyManager.GetRandomEnemy<Turret>(transform.position,minRadius.Value,maxRadius.Value)?.transform;
			cible=target.Value;
		}

	}

}