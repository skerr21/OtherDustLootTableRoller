Public Class Die

    Private _sides As Integer
        Private Shared _generator As New System.Random '<<<one PRNG no matter how many dice

        Public ReadOnly Property Sides As Integer
            Get
                Return _sides
            End Get
        End Property

        Public Sub New(sides As Integer)
            _sides = sides
        End Sub

        ''' <summary>
        ''' Returns a random number between 1 and the number of sides of the die
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Roll() As Integer
        Return _generator.Next(1, _sides + 1)
    End Function


End Class
