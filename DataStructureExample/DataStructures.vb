Option Strict On
Option Explicit On


Module DataStructures

    Sub Main()
        'ArrayExample()
        TestRandom()


        Console.ReadLine()
    End Sub

    Sub ArrayExample()
        Dim fruit(3) As String
        Dim names(1, 5) As String

        fruit(0) = "apple"
        fruit(1) = "banana"
        fruit(2) = "orange"
        fruit(3) = "pear"

        Console.WriteLine(fruit(2))

        For i = LBound(fruit) To UBound(fruit)
            Console.WriteLine(fruit(i))
        Next




        names(0, 0) = "Bob"
        names(1, 0) = "Marley"
        names(0, 1) = "Jimmy"
        names(1, 1) = "Page"

        Console.ReadLine()

    End Sub
    Sub TestRandom()
        Dim biggestNumber As Integer = 10
        Dim randomNumbers(10) As Integer

        For i = 0 To 1000
            randomNumbers(RandomNumberInRange(6)) += 1
        Next

        For i = LBound(randomNumbers) To UBound(randomNumbers)
            Console.Write(CStr(i).PadLeft(4) & " |")

        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(80, "-"))

        For i = LBound(randomNumbers) To UBound(randomNumbers)
            Console.Write(CStr(randomNumbers(i)).PadLeft(4) & " |")
        Next
    End Sub

    Function RandomNumberInRange(max As Integer) As Integer
        Dim randomNumber As Integer

        System.Math.Round(1.5)
        randomNumber = CInt(System.Math.Floor(Rnd() * (max + 1)))
        Return randomNumber
    End Function

End Module
