using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMove playerMove;

    private void Awake()
    {
        playerMove = GetComponent<PlayerMove>();
    }

    private void Update()
    {
        // 우클릭 버튼
        if (Input.GetMouseButtonDown(1))
        {
            InputMove();
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            // 작업 취소 요청
            CommandManager.UndoCommand();
        }
    }

    private void InputMove()
    {
        // 카메라로부터 마우스 위치로 향하는 ray 생성
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // 위 ray를 통해 레이캐스트를 진행하여 Ground가 있는지 확인
        if (Physics.Raycast(ray, out RaycastHit hit, 25f, (1 << LayerMask.NameToLayer("Ground"))))
        {
            // Move Command 생성
            MoveCommand moveCommand = new MoveCommand(playerMove, transform.position, hit.point);
            
            // Move Command 실행 요청
            CommandManager.ExecuteCommand(moveCommand);
        }
    }
}
