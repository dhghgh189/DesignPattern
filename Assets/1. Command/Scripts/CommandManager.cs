using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    // 가장 마지막에 수행한 작업을 되돌리기 위해
    // Stack을 선언하여 Command 내역을 기록한다.
    private static Stack<ICommand> undoStack = new Stack<ICommand>();

    // undo한 작업의 재 실행을 위해 redo Stack 추가
    private static Stack<ICommand> redoStack = new Stack<ICommand>();

    // 커맨드 실행 요청
    public static void ExecuteCommand(ICommand command)
    {
        // 요청받은 커맨드를 실행한다.
        command.Execute();

        // 실행 후 커맨드를 undoStack에 기록한다.
        undoStack.Push(command);

        // 새 작업이 실행되었으므로 redo Stack을 초기화 한다.
        redoStack.Clear();
    }

    // 되돌리기 실행 요청
    public static void UndoCommand()
    {
        // 최근에 실행한 Command가 있는지 체크
        if (undoStack.Count <= 0)
            return;

        // undoStack에서 가장 마지막으로 실행한 커맨드를 가져온다.
        ICommand command = undoStack.Pop();
        
        // 되돌리기 실행
        command.Undo();
        
        // 재 실행 가능하도록 redo Stack에 저장
        redoStack.Push(command);
    }

    // 되돌린 작업에 대한 재 실행 요청
    public static void RedoCommand()
    {
        // 재 실행 가능한 Command가 있는지 체크
        if (redoStack.Count <= 0)
            return;

        // 재 실행할 커맨드를 가져온다.
        ICommand command = redoStack.Pop();

        // 재 실행
        command.Execute();

        // 재 실행한 작업을 다시 undo Stack에 저장
        undoStack.Push(command);
    }

}
