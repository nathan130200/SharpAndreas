Imports SharpAndreas
Imports System.Threading
Imports System.Threading.Tasks

Public NotInheritable Class HelloVB
    Inherits SharpAndreas.Mod
    Private context As ModContext
    Private held As Boolean
    Private ticks As Integer
    Public Overrides Sub Start(value As ModContext)
        context = value
        context.Log("VB mod started. Press F7 for a message.")
    End Sub
    Public Overrides Sub Tick()
        Dim down = Game.IsKeyDown(&H76) ' F7
        If down AndAlso Not held Then Game.ShowHelp("Hello from Visual Basic and CoreCLR!")
        held = down
        If ticks < 3 Then
            context.Log("VB tick")
            ticks += 1
        End If
    End Sub
    Public Overrides Sub [Stop]()
        context.Log("VB stopped")
    End Sub
    Public Overrides Async Function RunAsync(value As ModContext, cancellationToken As CancellationToken) As Task
        Await Delay(1000, cancellationToken)
        Dim player = SharpAndreas.Player.Local.Character
        If player IsNot Nothing Then value.Log($"Async VB: player {player.Handle}, health {player.Health}")
    End Function
End Class

