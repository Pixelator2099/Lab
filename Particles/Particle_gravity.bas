
Screen 0
Screen 12
Cls

Type Item
    x As Integer
    y As Integer
    xa As Integer
    ya As Integer
    c As Integer
    xspeed As Integer
End Type

Dim Shared clouds(100) As Item
init
Show

Sub init ()
    Dim x As Integer

    For x = 0 To 100
        createitem x
    Next
End Sub

Sub createitem (x As Integer)
    Randomize Timer
    clouds(x).x = 250 + Rnd * 90
    clouds(x).y = 50 + Rnd * 90
    clouds(x).xa = 1 + Rnd * 15
    clouds(x).xspeed = 1
    clouds(x).ya = 1 + Rnd * 3

    clouds(x).c = 1 + Rnd * 10

    If (Rnd * 2) > 1 Then
        '     clouds(x).ya = clouds(x).ya * -1
    End If

    If (Rnd * 2) > 1 Then
        clouds(x).xa = clouds(x).xa * -1
        clouds(x).xspeed = -1
    End If




End Sub


Sub Show ()
    Dim counter As Integer
    Do

        Screen 12, , 0, 1
        Cls
        Print "Particles by Carlos Chang FB @sistemaswebchang"
        For x = 0 To 100

            ' Move Item

            clouds(x).y = clouds(x).y + clouds(x).ya
            clouds(x).x = clouds(x).x + clouds(x).xa

            If (Abs(clouds(x).xa) > 1) Then
                clouds(x).xa = clouds(x).xa - clouds(x).xspeed
            End If


            Circle (clouds(x).x, clouds(x).y), 10, clouds(x).c
            Paint (clouds(x).x, clouds(x).y), clouds(x).c, clouds(x).c

            ' Restart Item
            If clouds(x).x > 700 Then
                createitem x
                counter = counter + 1
            End If


            If counter > 70 Then
                init
                counter = 0
            End If

        Next
        Rem    Screen 12, , 1, 0
        PCopy 0, 1
        _Delay 0.02
    Loop Until InKey$ <> ""
End Sub



