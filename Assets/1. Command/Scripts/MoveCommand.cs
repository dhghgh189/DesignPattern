using UnityEngine;

public class MoveCommand : ICommand
{
    private PlayerMove playerMove;

    private Vector3 beforePos;      // Undo를 위해 이동전 위치를 기억
    private Vector3 targetPos;      // 커맨드 실행 시 이동해야 할 위치

    public MoveCommand(PlayerMove playerMove, Vector3 beforePos, Vector3 targetPos)
    {
        this.playerMove = playerMove;
        this.beforePos = beforePos;
        this.targetPos = targetPos;
    }

    // 커맨드 실행
    public void Execute()
    {
        playerMove.SetPos(targetPos);
    }

    // 작업 되돌리기
    public void Undo()
    {
        playerMove.SetPos(beforePos);
    }
}
