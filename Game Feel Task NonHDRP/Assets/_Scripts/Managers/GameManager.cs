using System;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static event Action<GameState> OnBeforeStateChanged;
    public static event Action<GameState> OnAfterStateChanged;

    public GameState State { get; private set; }
    public Transform GameStartSpawningPosition;

    // Kick the game off with the first state
    private void Start() => ChangeState(GameState.STARTING);

    public void ChangeState(GameState newState) {
        OnBeforeStateChanged?.Invoke(newState);

        State = newState;
        switch (newState) {
            case GameState.STARTING:
                HandleStarting();
                break;
            case GameState.SPAWNING:
                HandleSpawning();
                break;
            case GameState.SIMULATION:
                break;
            case GameState.RESULT:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnAfterStateChanged?.Invoke(newState);
        
        //Debug.Log($"New state: {newState}");
    }

    private void HandleStarting() {
        // Do some start setup, could be environment, cinematics etc

        // Eventually call ChangeState again with your next state
        
        ChangeState(GameState.SPAWNING);
    }

    private void HandleSpawning() {
        //utilize spawning objects
        ObjectPooler._Instance.FillThePoolCollection();
        /* ObjectPooler._Instance.GetObjectFromPool("YellowProjectile", GameStartSpawningPosition.position, ObjectPooler._Instance.pools[0].prefab.transform.localScale);
        ObjectPooler._Instance.GetObjectFromPool("BlueProjectile", GameStartSpawningPosition.position, ObjectPooler._Instance.pools[1].prefab.transform.localScale);
        ObjectPooler._Instance.GetObjectFromPool("RedProjectile", GameStartSpawningPosition.position, ObjectPooler._Instance.pools[2].prefab.transform.localScale); */

        ChangeState(GameState.SIMULATION);
    }

}

[Serializable]
public enum GameState {
    STARTING = 0,
    SPAWNING = 1,
    SIMULATION = 2,
    RESULT = 4,    
}
