Module ExplicitConversionDateToObject1
    Function Main() As Integer
        Dim result As Boolean
        Dim value1 As Date
        Dim value2 As Object
        Dim const2 As Object

        value1 = #01/01/2000 12:34#
        value2 = CObj(value1)
        const2 = CObj(#01/01/2000 12:34#)

        result = Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(value2, const2, False)

        If result = False Then
            System.Console.WriteLine("FAIL ExplicitConversionDateToObject1")
            Return 1
        End If
    End Function
End Module
