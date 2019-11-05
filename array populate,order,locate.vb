Module Module1

    Sub Main()
        Dim Num(8) As String
        Dim i, j, x, a, b, y, z, count As Integer
        Dim isfound As Boolean
        isfound = False
        Num(8) = ""
        i = 0
        j = 0
        x = 0
        a = 0
        b = 0
        y = 1
        z = 0
        count = 0



        Console.WriteLine("Enter values for the array:")
        For i = 1 To 8
            x = Console.ReadLine
            Num(i) = x

        Next
        For j = 7 To 1 Step -1
            For i = 1 To j
                If Num(i) > Num(i + 1) Then
                    a = Num(i)
                    Num(i) = Num(i + 1)
                    Num(i + 1) = a


                End If
            Next
        Next
        Console.WriteLine("values in ascending order are:")
        For i = 1 To 8
            b = Num(i)
            Console.WriteLine(b)
        Next
        Console.WriteLine("enter value to be found:")
        z = Console.ReadLine
        While isfound = False And y <= 8
            If Num(y) = z Then
                isfound = True
                For count = 1 To 8
                    If Num(count) = z Then
                        Console.WriteLine("value found at" & " " & count & " " & "position")
                    End If
                Next
            End If
            y = y + 1
        End While
        If isfound = False Then
            Console.WriteLine("value not found")
        End If


        Console.ReadKey()

    End Sub

End Module
