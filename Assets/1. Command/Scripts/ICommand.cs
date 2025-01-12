public interface ICommand
{
    public void Execute();  // 작업 실행 시
    public void Undo();     // 작업 되돌리기 
}
