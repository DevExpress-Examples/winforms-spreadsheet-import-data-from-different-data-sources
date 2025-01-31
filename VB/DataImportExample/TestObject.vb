Namespace DataImportExample

#Region "#testobject"
    Friend Class TestObject

        Public Sub New(ByVal intValue As Integer, ByVal value As String, ByVal boolValue As Boolean, ByVal imageValue As Byte())
            intValueField = intValue
            Me.Value = value
            Me.BoolValue = boolValue
            Me.ImageValue = imageValue
        End Sub

        Public Sub New(ByVal intValue As Integer, ByVal value As String, ByVal boolValue As Boolean, ByVal imageBase64 As String)
            intValueField = intValue
            Me.Value = value
            Me.BoolValue = boolValue
            Me.ImageBase64 = imageBase64
        End Sub

        Public intValueField As Integer

        Private ReadOnly Property privateValue As Integer
            Get
                Return 123
            End Get
        End Property

        Public ReadOnly Property IntValue As Integer
            Get
                Return intValueField + privateValue - 123
            End Get
        End Property

        Public Property Value As String

        Public Property BoolValue As Boolean

        Public Property ImageValue As Byte()

        Default Public ReadOnly Property Item(ByVal index As Integer) As Integer
            Get
                Return index
            End Get
        End Property

        Public Property ImageBase64 As String
    End Class
#End Region  ' #testObject
End Namespace
