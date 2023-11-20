using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class IdleState : IState
{
    float randomTime;
    float timer;

    public void OnEnter(Enemy enemy)
    {
        enemy.StopMoving();
        timer = 0;
        randomTime = Random.Range(2f, 4f);
    }

    public void OnExcute(Enemy enemy)
    {
       timer += Time.deltaTime;
       if(timer > randomTime)
        {
            enemy.ChangeState(new PatrolState());
        }
    }

    public void OnExit(Enemy enemy)
    {
      
    }

    // Start is called before the first frame update
  
}
