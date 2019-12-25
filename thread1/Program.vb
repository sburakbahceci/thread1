Imports System.Threading
Module Module1
    Private Sub dosya(a As Object)
        FileOpen(1, "mesaj.txt", OpenMode.Output)
        Write(1, a)
        FileClose(1)
    End Sub
    Private Sub th1(ByVal m As Object)
        For i As Integer = 0 To 100
            Console.Write(m)
            Thread.Sleep(100)
            dosya(m)
        Next
    End Sub
    Private Sub th2(ByVal l As Object)
        For i As Integer = 0 To 100
            Console.Write(l)
            Thread.Sleep(100)
            dosya(l)
        Next
    End Sub
    Sub Main()
        Dim thread1 As Thread
        Dim thread2 As Thread

        thread1 = New Thread(AddressOf th1)
        thread1.Start("_")
        thread2 = New Thread(AddressOf th2)
        thread2.Start("-")
    End Sub
End Module
